using ReadWrite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;



namespace _313ass2
{


    public partial class Form1 : Form
    {
        Chamber chamber1;
        SensorArray sensors;

        double medianTemp;

        int filterLength;
        FilterType filterType;
        Filter filter;

        int bufferLength;

        Thread readThread;
        Thread controllerThread;

        string device = "dev6";

        bool exited;


        public Form1()
        {

            InitializeComponent();


            filterLength = 10;
            filterType = FilterType.Avg;
            filter = new Filter(filterType, filterLength);


            bufferLength = 100;

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
            for (int i = 1; i <= 3; i++) {
                File.Delete(Application.StartupPath + "\\logfiles\\log" + i + ".txt");
            }


        }


        public static double[] Convolve(double[] sensorReadings, double[] filterValues, int ringIndex)
        {
            int filterLen = filterValues.Length;
            int bufferLen = sensorReadings.Length;
            double newValue = 0.0;
            double[] filterReadings = new double[bufferLen];
            Array.Reverse(filterValues, 0, filterLen); // flip filter array
            double filterVal;

            for (int i = 0; i < bufferLen; i++) //TODO: Double check this
            {
                if (i > (bufferLen - filterLen - 1))
                {
                     filterVal = filterValues[i - (bufferLen - filterLen)];
                }
                else
                {
                    filterVal = 0;
                }
                newValue += sensorReadings[(ringIndex + i) % bufferLen] * filterVal; // convolution
                filterReadings[i] = newValue;
            }
            return filterReadings;
        }

        void c_ToolChanged(object sender, ToolChangedEventArgs e) //ToolState button update handler
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

        private void Form1_Load(object sender, EventArgs e)
        {
            filterTypeCombo.SelectedIndex = 0;
            exited = false;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void Form1_Closing(Object sender, FormClosingEventArgs e) //TODO: figure out why this isn't firing?!
        {
            if (exited == false)
            {
                e.Cancel = true;
                exited = true;
            }
        }

        private void filterUpdateButton_Click(object sender, EventArgs e)
        {
            FilterType selectedFilter;
            int selectedLength;

            switch (filterTypeCombo.SelectedIndex)
            {
                case (0):
                    selectedFilter = FilterType.Avg;
                    break;
                case (1):
                    selectedFilter = FilterType.Linear;
                    break;
                case (2):
                    return;
                default:
                    return;
            }

            selectedLength = (int)filterLengthUpDown.Value;

            filter = new Filter(selectedFilter, selectedLength);

            //double[] copyArray1 = sensors.sens1Buffer;
            //double[] copyArray2 = sensors.sens2Buffer;
            //double[] copyArray3 = sensors.sens3Buffer;


        }

        private double[] loadCustomFilter()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    
                    double[] filterValues;
                    string line;
                    try
                    {
                        // Read filter into single string
                        using (StreamReader sr = new StreamReader(filePath))
                        {
                            line = sr.ReadToEnd();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Could not read file");
                        return null;
                    }

                    string[] Parameters = line.Split(' ');
                    filterValues = new double[Parameters.Length];
                    for (int i = 0; i < Parameters.Length - 1; i++)
                    {
                        try
                        {   // Split string into filter values and add to new filter array
                            filterValues[i] = Convert.ToDouble(Parameters[i]);
                        }
                        catch
                        {
                            MessageBox.Show("Could not read file");
                            return null;
                        }

                    }

                    return filterValues;
                }
                return null; // Failure as show file dialog can't open
            }
        }

        private void openLogfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open folder where logfiles are writter (Folder next to .exe)
            System.Diagnostics.Process.Start(Application.StartupPath + "\\logfiles");
        }

        private void saveFilterConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image  
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
                    // Write filter weights to file separated by spaces
                    filterString = filterString + filter.FilterArray[i].ToString() + " ";
                }

                System.IO.File.WriteAllText(saveFileDialog1.FileName, filterString);
            }
        }

        //Timers
        private void timer1_Tick(object sender, EventArgs e)
        {

            //Update all displays

            temperature1.Text = sensors.temp1.ToString("N2");
            temperature2.Text = sensors.temp2.ToString("N2");
            temperature3.Text = sensors.temp3.ToString("N2");

            ambientTempDisplay.Text = sensors.ambientTemp.ToString("N2");

            setTempLabel.Text = (sensors.ambientTemp + chamber1.setPoint).ToString("N2");
            
            controllerInputTemp.Text = medianTemp.ToString("N2");
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            

            // Add selected sensor values to a list
            List<double> inputValues = new List<double>();
            
            if (temp1CheckBox.Checked)
            {
                inputValues.Add(sensors.temp1);
            }
            if (temp2CheckBox.Checked)
            {
                inputValues.Add(sensors.temp2);
            }
            if (temp3CheckBox.Checked)
            {
                inputValues.Add(sensors.temp3);
            }

            if (inputValues.Count > 0)
            {
                //calculate median of the selected values
                inputValues.Sort();
                if (inputValues.Count % 2 == 0)
                {
                    medianTemp = (inputValues[(inputValues.Count / 2) - 1] + inputValues[(inputValues.Count / 2)]) / 2;
                }
                else
                {
                    medianTemp = inputValues[(inputValues.Count / 2)];
                }


            }
            else
            {
                medianTemp = 0;
            }

            //Set the control temp for the controller
            chamber1.controlTemp = medianTemp;
            sensors.timestamp = chamber1.stopwatch.ElapsedMilliseconds;

            //if filter is stabilising on startup, allow ambient temp to change
            if (sensors.timestamp < 600 * filter.Length)
            {
                chamber1.ambientTemp = medianTemp;
                sensors.ambientTemp = medianTemp;
            }


            // If we've exited the program, run the chamber to cool temp
            if (exited)
            {
                this.Hide();

                chamber1.setPoint = 0;
                chamber1.controllerEnabled = true;
                //If we've reached exit conditions of being cool enough
                if (chamber1.controlTemp - chamber1.ambientTemp < 0) 
                {
                    //stop system and nuke processes
                    chamber1.fan.on = false;
                    chamber1.heater.on = false;
                    readThread.Abort();
                    controllerThread.Abort();
                    Application.Exit();
                }

            }

            // set chamber control loop and sensor read loop to run
            chamber1.cycle = true;
            sensors.cycle = true;


        }
        
        //Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            //exited = true;
            
        }

        //Button Pushes
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


        //Controller Variables

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


        private void loadFilterConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] filterVals = loadCustomFilter();
            if (filterVals != null)
            {
                filter.Length = filterVals.Length;
                filter.FilterArray = filterVals;
            }
        }

        private void filterTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (filterTypeCombo.SelectedIndex)
            {
                case (2):
                    {
                        double[] filterVals = loadCustomFilter();
                        if (filterVals != null)
                        {
                            filter.Length = filterVals.Length;
                            filter.FilterArray = filterVals;
                        }
                    }
                    return;
            }
        }

        // Reset ambient temp
        private void button1_Click(object sender, EventArgs e)
        {
            chamber1.ambientTemp = chamber1.controlTemp;
            sensors.ambientTemp = chamber1.controlTemp;
        }

        // Unused
        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Temp1CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void Temperature3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void setTempLabel_Click(object sender, EventArgs e)
        {

        }
    }

    

    

}


