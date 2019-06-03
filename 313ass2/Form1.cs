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

        Sensor sensor1, sensor2, sensor3;

        int filterLength;
        FilterType filterType;
        Filter filter;

        int ringIndex;
        double[] sens1Buffer;
        double[] sens2Buffer;
        double[] sens3Buffer;

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

            sensor1 = new Sensor(0, device, 10000, 3380, 298.15, filterLength);
            sensor2 = new Sensor(1, device, 5000, 3960, 298.15, filterLength);
            sensor3 = new Sensor(2, device, 100000, 4380, 298.15, filterLength);

            ringIndex = 0;
            sens1Buffer = new double[filterLength];
            sens2Buffer = new double[filterLength];
            sens3Buffer = new double[filterLength];

            chamber1 = new Chamber();
            
            //Button update event handlers
            chamber1.fan.ToolChanged += c_ToolChanged;
            chamber1.heater.ToolChanged += c_ToolChanged;

            //Start controller as own thread
            Thread controllerThread = new Thread(()=>Chamber.Controller(chamber1)); //Using anonymous methods and lambda expressions?!
            controllerThread.Start();

            //Delete old logfiles
            for(int i = 1; i <= 3; i++) {
                File.Delete(Application.StartupPath + "\\logfiles\\log" + i + ".txt");
            }
        }

        private static double[] Convolve(double[] sensorReadings, double[] filterValues,  int ringIndex)
        {
            int typeLen = filterValues.Length;
            int bufferLen = sensorReadings.Length;
            double newValue = 0.0;
            double[] filterReadings = new double[bufferLen];

            for (int j = 0; j < typeLen; j++)
            {
                for (int i = bufferLen - 1; i >= 0; i--)
                {
                    if ((j - i) < 0) continue;

                    newValue += sensorReadings[(ringIndex + i)%bufferLen] * filterValues[j - i]; // convolution
                }
                filterReadings[j] = newValue;
            }
            return filterReadings;
        }





        private void Form1_Load(object sender, EventArgs e)
        {

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
            chamber1.controllerEnabled = true;
            if (chamber1.controllerEnabled)
            {

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
            chamber1.active = false;
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
                default:
                    throw new System.ArgumentException("Invalid filter type");
                    
            }
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
            //TODO: Thread this whole thing
            double temp1 = sensor1.getSensorTemp();
            double temp2 = sensor2.getSensorTemp();
            double temp3 = sensor3.getSensorTemp();

            temperature1.Text = temp1.ToString();
            temperature2.Text = temp2.ToString();
            temperature3.Text = temp3.ToString();
            string date = DateTime.Now.ToString("HH:mm:ss.fff");

            string logfolder = Application.StartupPath + "\\logfiles";
            System.IO.Directory.CreateDirectory(logfolder);

            

            using (StreamWriter sw = new StreamWriter(logfolder + "/log1.txt", append: true))
            {
                sw.WriteLine(date + " " + temp1.ToString());
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter(logfolder + "/log2.txt", append: true))
            {
                sw.WriteLine(date + " " + temp2.ToString());
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter(logfolder + "/log3.txt", append: true))
            {
                sw.WriteLine(date + " " + temp3.ToString());
                sw.Close();
            }


            sens1Buffer[ringIndex] = temp1;
            sens2Buffer[ringIndex] = temp2;
            sens3Buffer[ringIndex] = temp3;
            ringIndex = (ringIndex + 1) % filterLength;


            double[] temp1_filtered = Convolve(sens1Buffer, filter.FilterArray, ringIndex);
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

        

        public bool active = true;

        double controlTemp;
        private double _setPoint = 0;
        public double ambientTemp;
        private bool _controllerEnabled = false;

        public double kp = 1;
        public double ki = 0;
        double error = 0;
        double P = 0;
        double I = 0;
        double y = 0;
        public double setPoint
        {
            get { return _setPoint; }
            set { _setPoint = Clamp(value, 0.0, 3.0); }
        }
        
        public bool controllerEnabled
        {
            get
            { 
                return _controllerEnabled;
            }
            set
            {
                _controllerEnabled = value;
            }
        }

        public Chamber()
        {
            string device = "dev6";
            dOut.OpenChannel(device+"/port0", "DigitalChn0");
        }


        public static void Controller(Chamber selChamber)
        {
            //Controller calculations
            while (selChamber.active && Math.Abs(selChamber.error) > 1)
            {

                selChamber.error = selChamber.setPoint + selChamber.ambientTemp - selChamber.controlTemp;

                selChamber.P = selChamber.error * selChamber.kp;
                selChamber.I += selChamber.error * selChamber.ki;
                selChamber.y = selChamber.P + selChamber.I;

                //Convert to output and
                //Only apply output if controller is "started"
                if (selChamber._controllerEnabled)
                {
                    if (selChamber.y > 0)
                    {
                        selChamber.heater.on = true;
                        selChamber.fan.on = false;
                    }
                    else
                    {
                        selChamber.heater.on = false;
                        selChamber.fan.on = true;
                    }
                }
                else
                {
                    selChamber.heater.on = false;
                    selChamber.fan.on = false;
                }

                Thread.Sleep(10); // Run PID loop at ~100hz
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

            Array.Reverse(FilterArray);


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
            analogInput.OpenChannel(device+"/ai"+ID, "Ainput");
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
}
