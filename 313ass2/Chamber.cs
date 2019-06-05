using ReadWrite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace _313ass2
{

    class Chamber
    {
        public Tool fan = new Tool(0);
        public Tool heater = new Tool(1);

        public static DigitalO dOut; 

        public Stopwatch stopwatch;

        public bool cycle = true;

        public double controlTemp;
        public double ambientTemp;
        //private double _setPoint = 0;


        public double kp = 1;
        public double ki = 0;
        public double kd = 0;
        public double error = 0;
        double P = 0;
        double I = 0;
        double D = 0;
        double y = 0;

        double error_last = 0;

        public double heaterThreshold = 0.1;
        public double fanThreshold = 0;

        private double _setPoint;

        public double setPoint
        {
            get { return _setPoint; }
            set { _setPoint = Clamp(value, 0.0, 3.0); }
        }

        public bool controllerEnabled;

        public Chamber(string device)
        {

            stopwatch = new Stopwatch();
            stopwatch.Start();


            try
            {
                dOut = new DigitalO();

                dOut.OpenChannel(device + "/port0", "DigitalChn0");
            }
            catch { }
            controllerEnabled = false;
            setPoint = 0;
        }


        public void Controller()
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
                        else if (y < (-1 * fanThreshold))
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
}
