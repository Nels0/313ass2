using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _313ass2
{
    class SensorArray
    {
        public Sensor sensor1, sensor2, sensor3;
        public int _bufferLength = 1000;

        Filter _filter;

        public long timestamp;
        
        public bool cycle;

        public bool current = true; // Boolean to end thread

        public int ringIndex;
        public double[] sens1Buffer;
        public double[] sens2Buffer;
        public double[] sens3Buffer;

        public double temp1, temp2, temp3;

        public SensorArray(int bufferLength, string device, Filter filter)
        {
            this._filter = filter;
            this._bufferLength = bufferLength;
            sensor1 = new Sensor(0, device, 10000, 3380, 298.15, bufferLength);
            sensor2 = new Sensor(1, device, 5000, 3960, 298.15, bufferLength);
            sensor3 = new Sensor(2, device, 100000, 4380, 298.15, bufferLength);

            ringIndex = 0;
            sens1Buffer = new double[bufferLength];
            sens2Buffer = new double[bufferLength];
            sens3Buffer = new double[bufferLength];


        }


        public void readSensors()
        {
            while (current)
            {

                if (cycle)
                {
                    //string date = DateTime.Now.ToString("HH:mm:ss.fff");
                    string logfolder = Application.StartupPath + "\\logfiles";
                    System.IO.Directory.CreateDirectory(logfolder);

                    //TODO put sensors into a list so we avoid duplication

                    double t_temp1 = sensor1.getSensorTemp();
                    double t_temp2 = sensor2.getSensorTemp();
                    double t_temp3 = sensor3.getSensorTemp();

                    sens1Buffer[ringIndex] = t_temp1;
                    sens2Buffer[ringIndex] = t_temp2;
                    sens3Buffer[ringIndex] = t_temp3;
                    ringIndex = (ringIndex + 1) % _bufferLength;

                    double[] filteredBuffer1 = new double[_bufferLength];
                    double[] filteredBuffer2 = new double[_bufferLength];
                    double[] filteredBuffer3 = new double[_bufferLength];

                    //convolve to denoise
                    filteredBuffer1 = Form1.Convolve(sens1Buffer, _filter.FilterArray, ringIndex);
                    filteredBuffer2 = Form1.Convolve(sens2Buffer, _filter.FilterArray, ringIndex);
                    filteredBuffer3 = Form1.Convolve(sens3Buffer, _filter.FilterArray, ringIndex);

                    //set last value of filtered buffer to temp1
                    temp1 = filteredBuffer1[_bufferLength - 1];
                    temp2 = filteredBuffer2[_bufferLength - 1];
                    temp3 = filteredBuffer3[_bufferLength - 1];

                    using (StreamWriter sw = new StreamWriter(logfolder + "/log1.txt", append: true))
                    {
                        sw.WriteLine(timestamp.ToString() + " " + t_temp1.ToString() + " " + temp1.ToString());
                        sw.Close();
                    }

                    using (StreamWriter sw = new StreamWriter(logfolder + "/log2.txt", append: true))
                    {
                        sw.WriteLine(timestamp.ToString() + " " + t_temp2.ToString() + " " + temp2.ToString());
                        sw.Close();
                    }

                    using (StreamWriter sw = new StreamWriter(logfolder + "/log3.txt", append: true))
                    {
                        sw.WriteLine(timestamp.ToString() + " " + t_temp3.ToString() + " " + temp3.ToString());
                        sw.Close();
                    }

                    cycle = false;
                }
                else
                {
                    Thread.Sleep(1);
                }

            }
            try
            {
                sensor1.analogInput.CloseChannel();
                sensor2.analogInput.CloseChannel();
                sensor3.analogInput.CloseChannel();
            }
            catch { }

        }
    }
}
