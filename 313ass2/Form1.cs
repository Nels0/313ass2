using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReadWrite;
using System.Threading;


namespace _313ass2
{

    public partial class Form1 : Form
    {
        Chamber chamber1;

 
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


            chamber1 = new Chamber();

            chamber1.fan.ToolChanged += c_ToolChanged;
            chamber1.heater.ToolChanged += c_ToolChanged;

            Thread controllerThread = new Thread(()=>Chamber.Controller(chamber1)); //Using anonymous methods and lambda expressions
            controllerThread.Start();




            //dOut.OpenChannel(device+"/port0", "DigitalChn0");
            //aIn0.OpenChannel("dev6/ai0", "Ainput");
            //aIn1.OpenChannel("dev6/ai1", "Ainput");
            //aIn2.OpenChannel("dev6/ai2", "Ainput");

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
            chamber1.controllerEnabled = !chamber1.controllerEnabled;
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
        public double[] FilterArray
        {
            get { return this.FilterArray; }
            set { }

        }
        
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


        Filter()
        {
            generateFilter(FilterType.Avg, 10);
        }

        Filter(FilterType genType, int genLength)
        {
            generateFilter(genType, genLength);
        }
        private void generateFilter(FilterType genType, int genLength)
        {
            if(genLength < 0 || genLength > 10000) //Check length
            {
                throw new System.ArgumentException("Filter length out of range");
            }
            

            FilterArray = new double[_length];
            double dLength = (double)_length;

            switch (genType)
            {
                case FilterType.Avg:
                    for (int i = 0; i < _length; i++)
                    {
                        FilterArray[i] = 1 / dLength;
                    }
                    break;

                case FilterType.Linear:
                    for (int i = 0; i < _length; i++)
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

            _length = genLength;
            _type = genType;

        }
    }
}
