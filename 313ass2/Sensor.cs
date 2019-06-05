using ReadWrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _313ass2
{

    class Sensor
    {
        double Ro, B, To, R, refV, sensorReading;
        public AnalogI analogInput;
        string device;

        public double[] buffer;

        public Sensor(int ID, string device, double sRo, double sB, double sTo, int filterLength)
        {
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

        void readTemp()
        {
            //Poll Analog channel
            try
            {
                sensorReading = analogInput.ReadData();
            }
            catch { }

        }

    }
}
