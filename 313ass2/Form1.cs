using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ReadWrite;
using System.Threading;


namespace _313ass2
{

    public partial class Form1 : Form
    {
        Chamber chamber1;
        SensorArray sensors;
        

        int filterLength;
        FilterType filterType;
        Filter filter;

        int bufferLength;
        Thread readThread;
        Thread controllerThread;



        string device = "dev6";
 
        void c_ToolChanged(object sender, ToolChangedEventArgs e)
        {

            Chamber.dOut.WriteData(Tool.toolRegister);

            int buttonID = e.button;
            Button stateButton;

                switch (buttonID)
                {
                    case 0:
                        stateButton = fanButton;
                        break;
                    case 1:
                        stateButton = heaterButton;
                        break;
                    default:
                        throw new System.ArgumentException("Invalid buttonID for ButtonUpdate");
                }

                if ((Tool.toolRegister & (1 << buttonID)) >> buttonID == 1)
                {
                    stateButton.BackColor = Color.Brown;
                }
                else
                {
                    stateButton.BackColor = Color.AliceBlue;
                }
            

        }

        public Form1()
        {

            InitializeComponent();

            filterLength = 10;
            filterType = FilterType.Avg;
            filter = new Filter(filterType, filterLength);


            bufferLength = 10;


            sensors = new SensorArray(bufferLength, device, filter);

            chamber1 = new Chamber(device);

            chamber1.ambientTemp = sensors.ambientTemp;

            //Button update event handlers
            chamber1.fan.ToolChanged += c_ToolChanged;
            chamber1.heater.ToolChanged += c_ToolChanged;

            //Start controller as own thread
            //controllerThread = new Thread(()=>Chamber.Controller(chamber1)); //Using anonymous methods and lambda expressions?!
            controllerThread = new Thread(chamber1.Controller);
            controllerThread.Start();

            readThread = new Thread(sensors.readSensors);
            readThread.Start();

            //Delete old logfiles
            for(int i = 1; i <= 3; i++) {
                File.Delete(Application.StartupPath + "\\logfiles\\log" + i + ".txt");
            }
            

        }

        public static double[] Convolve(double[] sensorReadings, double[] filterValues,  int ringIndex)
        {
            int typeLen = filterValues.Length;
            int bufferLen = sensorReadings.Length;
            double newValue = 0.0;
            double[] filterReadings = new double[bufferLen];
            Array.Reverse(filterValues, 0, typeLen); // flip type array

            for (int i = 0; i < bufferLen; i++)
                {
                  newValue += sensorReadings[(ringIndex + i) % bufferLen] * filterValues[i]; // convolution
                  filterReadings[i] = newValue;
                }   
            return filterReadings;
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            //Placeholder ambient temp calc
            //chamber1.ambientTemp = sensors.sensor1.getSensorTemp();
        }
       
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ControllerRunButton_Click(object sender, EventArgs e)
        {
            chamber1.controllerEnabled = !chamber1.controllerEnabled;
            if (chamber1.controllerEnabled)
            {
                controllerRunButton.Text = "Stop";
            }
            else
            {
                controllerRunButton.Text = "Start";
                chamber1.heater.on = false;
                chamber1.fan.on = false;
            }
                       
        }

        private void setTempBox_ValueChanged(object sender, EventArgs e)
        {
            chamber1.setPoint = (double)setTempBox.Value;
            setTempBox.Value = (decimal)chamber1.setPoint;
        }

        private void heaterButton_Click(object sender, EventArgs e)
        {
            chamber1.heater.on = !chamber1.heater.on;
        }

        private void fanButton_Click(object sender, EventArgs e)
        {
            chamber1.fan.on = !chamber1.fan.on;
        }

        private void Form1_Closing(Object sender, FormClosingEventArgs e) //TODO: figure out why this isn't firing?!
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
        }

        private void filterUpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void filterTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filterTypeCombo.DisplayMember)
            {
                case ("Average"):
                    
                    break;
                case ("Linear (Ramp)"):
                    break;
                case ("Exponential"):
                    break;
                default:
                    //throw new System.ArgumentException("Invalid filter type");
                    break;
                    
            }
            MessageBox.Show(filterTypeCombo.DisplayMember);
        }

        private void openLogfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\logfiles");
        }

        private void saveFilterConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Filter File|*.txt";
            saveFileDialog1.Title = "Save a Filter File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {

                string filterString = "";
                for (int i = 0; i < filter.Length; i++)
                {
                    filterString = filterString + filter.FilterArray[i].ToString() + " ";
                }

                System.IO.File.WriteAllText(saveFileDialog1.FileName, filterString);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            

            temperature1.Text = sensors.temp1.ToString("N2");
            temperature2.Text = sensors.temp2.ToString("N2");
            temperature3.Text = sensors.temp3.ToString("N2");

            ambientTempDisplay.Text = sensors.ambientTemp.ToString("N2");

            setTempLabel.Text = (sensors.ambientTemp + chamber1.setPoint).ToString("N2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: Exit properly
            //this.Hide();
        }

        private void kpUpDown_ValueChanged(object sender, EventArgs e)
        {
            chamber1.kp = (double)kpUpDown.Value;
        }

        private void kiUpDown_ValueChanged(object sender, EventArgs e)
        {
            chamber1.ki = (double)kiUpDown.Value;
        }

        private void kdUpDown_ValueChanged(object sender, EventArgs e)
        {
            chamber1.kd = (double)kdUpDown.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            chamber1.fanThreshold = (double)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            chamber1.heaterThreshold = (double)numericUpDown2.Value;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Transfer values
            chamber1.controlTemp = sensors.temp1;
            
            chamber1.cycle = true;
            sensors.cycle = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }



    class Tool
    {
        public event EventHandler<ToolChangedEventArgs> ToolChanged;

        
        static public int toolRegister = 0;
        private bool _on;
        protected int toolID;
        public bool on
        {
            get { return _on; }
            set
            {
                _on = value;
                commitState();
            }
        }

        public Tool(int ID)
        {
            

            toolID = ID;
            on = false;
            

            
        }

        private void commitState()
        {

            if (_on)
            {
                toolRegister |= (1 << toolID);
            }
            else
            {
                toolRegister &= ~(1 << toolID);
            }

            



            ToolChangedEventArgs e = new ToolChangedEventArgs //haha don't mess with this
            {
                button = toolID
            };
            ToolChanged?.Invoke(null, e);
        }

        

    }

    public class ToolChangedEventArgs : EventArgs {
        public int button { get; set; } 
    }

    class Chamber
    {
        public Tool fan = new Tool(0);
        public Tool heater = new Tool(1);


        public static DigitalO dOut = new DigitalO();

        

        public bool cycle = true;

        public double controlTemp;
        public double ambientTemp;
        //private double _setPoint = 0;
       

        public double kp = 1;
        public double ki = 0;
        public double kd = 0;
        double error = 0;
        double P = 0;
        double I = 0;
        double D = 0;
        double y = 0;

        double error_last = 0;

        public double heaterThreshold = 0.2;
        public double fanThreshold = 0.4;

        private double _setPoint;

        public double setPoint
        {
            get { return _setPoint; }
            set { _setPoint = Clamp(value, 0.0, 3.0); }
        }

        public bool controllerEnabled;

        public Chamber(string device)
        {
            //string device = "dev6";
            dOut.OpenChannel(device+"/port0", "DigitalChn0");
            controllerEnabled = false;
            setPoint = 0;
        }


        public  void Controller()
        {
            //Controller calculations


            while (true)
            {
                if (cycle)
                {

                    error = _setPoint + ambientTemp - controlTemp;

                    P = error * kp;
                    I += error * ki;
                    D = (error - error_last) * kd;
                    y = P + I + D;
                    error_last = error;

                    //Convert to output and
                    //Only apply output if controller is "started"
                    if (controllerEnabled)
                    {
                        if (y > heaterThreshold)
                        {
                            heater.on = true;
                            fan.on = false;
                        }
                        else if (y < fanThreshold)
                        {
                            heater.on = false;
                            fan.on = true;
                        }
                        else
                        {
                            heater.on = false;
                            fan.on = false;
                        }
                    }
                    
                    cycle = false;
                }
                else
                {
                    Thread.Sleep(1);
                }
            }
            

            
        }
        double Clamp(double value, double min, double max)
        {
            if (value < min)
            {
                return min;
            }
            else if (value > max)
            {
                return max;
            }
            else
            {
                return value;
            }
        }

    }
    enum FilterType { Avg, Linear, Exponential}
    class Filter
    {
        private FilterType _type;
        private int _length;
        public double[] FilterArray;
        
        public FilterType Type
        {
            get { return _type; }
            set { generateFilter(value, this._length); }
        }


        public int Length
        {
            get { return _length; }
            set { generateFilter(this._type, value); }
        }


        public Filter()
        {
            generateFilter(FilterType.Avg, 10);
        }

        public Filter(FilterType genType, int genLength)
        {
            generateFilter(genType, genLength);
        }
        private void generateFilter(FilterType genType, int genLength)
        {
            if(genLength < 0 || genLength > 10000) //Check length
            {
                throw new System.ArgumentException("Filter length out of range");
            }
            

            FilterArray = new double[genLength];
            double dLength = (double)genLength;
            _length = genLength;
            _type = genType;

            switch (genType)
            {
                case FilterType.Avg:
                    for (int i = 0; i < genLength; i++)
                    {
                        FilterArray[i] = 1 / dLength;
                    }
                    break;

                case FilterType.Linear:
                    for (int i = 0; i < genLength; i++)
                    {
                        FilterArray[i] = 2 / dLength - (2*i) / (dLength * dLength);
                    }
                    break;

                case FilterType.Exponential:
                    throw new System.ArgumentException("Filter not implemented");

                    //break;

                default:
                    throw new System.ArgumentException("Invalid Filter Type Specified");

            }

            //Array.Reverse(FilterArray); done in convolution


        }
    }

    class Sensor
    {
        double Ro, B, To, R, refV, sensorReading;
        AnalogI analogInput;
        public string device;

        public double[] buffer;

        public Sensor(int ID, string device, double sRo, double sB, double sTo, int filterLength) {
            buffer = new double[filterLength];
            analogInput = new AnalogI();
            Ro = sRo;
            B = sB;
            To = sTo;
            refV = 5;
            this.device = device;
            int success = analogInput.OpenChannel(device + "/ai" + ID, "Ainput");
            if (success == 0)
            {
                MessageBox.Show("Error!");
            }
        }

        public double getSensorTemp() 
        {
            readTemp();
            double T;
            R = (sensorReading * Ro) / (refV - sensorReading);
            double frac = (R) / (Ro * Math.Exp(-1.0 * B / To));
            T = B / Math.Log(frac);
            return T - 273.15; // convert to degrees celsius

        }

        void readTemp() {
            //Poll Analog channel
            sensorReading = analogInput.ReadData();
            
        }

    }

    class SensorArray
    {
        public Sensor sensor1, sensor2, sensor3;
        public int _bufferLength = 10;

        Filter _filter;

        public double ambientTemp;

        public bool cycle;

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

            ambientTemp = sensor2.getSensorTemp();

        }


        public void readSensors()
        {
            while (true)
            {

                if (cycle)
                {
                    //string date = DateTime.Now.ToString("HH:mm:ss.fff");
                    Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    string date = unixTimestamp.ToString();

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
                        sw.WriteLine(date + " " + t_temp1.ToString() + " " + temp1.ToString());
                        sw.Close();
                    }

                    using (StreamWriter sw = new StreamWriter(logfolder + "/log2.txt", append: true))
                    {
                        sw.WriteLine(date + " " + t_temp2.ToString() + " " + temp2.ToString());
                        sw.Close();
                    }

                    using (StreamWriter sw = new StreamWriter(logfolder + "/log3.txt", append: true))
                    {
                        sw.WriteLine(date + " " + t_temp3.ToString() + " " + temp3.ToString());
                        sw.Close();
                    }

                    cycle = false;
                }
                else
                {
                    Thread.Sleep(1);
                }
                
            }
        }
    }
}
