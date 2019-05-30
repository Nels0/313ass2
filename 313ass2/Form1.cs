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
        static int toolRegister = 0;
        static Tool fan = new Tool(0);
        static Tool heater = new Tool(1);
        static DigitalO dOut = new DigitalO();

        

        public Form1()
        {
            InitializeComponent();

            //string device = "dev6";

            //Chamber chamber1 = new Chamber();

           // Tool fan = new Tool(0);
            //Tool heater = new Tool(1);

            //dOut.OpenChannel(device+"/port0", "DigitalChn0");
            //aIn0.OpenChannel("dev6/ai0", "Ainput");
            //aIn1.OpenChannel("dev6/ai1", "Ainput");
            //aIn2.OpenChannel("dev6/ai2", "Ainput");

        }

        class Chamber
        {

            double readTemp;
            double setPoint;
            double ambientTemp;
            bool controllerEnabled;
            int kp;

            public Chamber()
            {
                kp = 1;
            }

            public void Controller()
            {
                //Controller calculations

                double error = setPoint - readTemp;

                double y = error * (double)kp;

                //Convert to output and
                //Only apply output if controller is "started"
                if (controllerEnabled)
                {
                    if (y > 0)
                    {
                        heater.on = true;
                        fan.on = false;
                    }
                    else
                    {
                        heater.on = false;
                        fan.on = true;
                    }
                }
                else
                {
                    heater.on = false;
                    fan.on = false;
                }
            }
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        class Tool
        {
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
                on = false;
                toolID = ID;
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

                dOut.WriteData(toolRegister);
            }

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
    }
}
