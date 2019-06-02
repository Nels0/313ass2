﻿using System;
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


        public Form1()
        {
            InitializeComponent();

            

            chamber1 = new Chamber();



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
    }

    class Tool
    {
        static DigitalO dOut = new DigitalO();
        static int toolRegister = 0;

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
            string device = "dev6";

            on = false;
            toolID = ID;
            //dOut.OpenChannel(device + "/port0", "DigitalChn0");
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

    class Chamber
    {
        Tool fan = new Tool(0);
        Tool heater = new Tool(1);

        double readTemp;
        double setPoint;
        double ambientTemp;
        private bool _controllerEnabled = false;
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
            if (_controllerEnabled)
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


}
