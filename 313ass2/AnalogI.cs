using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;
using NationalInstruments;

namespace ReadWrite
{
    class AnalogI
    {
        // Create a new task for an analog input
        Task analogIn = new Task();
        // Create a new single analog channel reader
        AnalogSingleChannelReader reader;
        // Create new AnalogWaveform type to hold the read data
        NationalInstruments.AnalogWaveform<double> data;
        int samplesPerChannel = 2;

        public void OpenChannel(string portLine, string portName)
        {
            // Create a new analog inputChannel called "Ainport0"
            analogIn.AIChannels.CreateVoltageChannel(portLine, // The physical name of the channel
                portName, // The given name to the channel
                AITerminalConfiguration.Rse, //Input type (Differential, RSE, NRSE)
                -10.0, 10.0, //Input Voltage Range
                AIVoltageUnits.Volts); //Input unit

            //Configure timing specs
            analogIn.Timing.ConfigureSampleClock("",//external clock source line, "" for internal clock
                10.0,                               // rate of internal/external clock (10hz)
                SampleClockActiveEdge.Rising,       // acquisition on rising or falling edge of ticks
                SampleQuantityMode.FiniteSamples,   // continous or finite samples
                samplesPerChannel);                 // number of finite samples to acquire or used for buffer size if continous

            // Initialise the single analog input channel reader
            reader = new AnalogSingleChannelReader(analogIn.Stream);
        }

        public double ReadData()
        {
            data = reader.ReadWaveform(samplesPerChannel);
            double sum = 0;
            for (int i = 0; i < samplesPerChannel; i++)
            {
                sum += data.Samples[i].Value;
                //Console.WriteLine("Sample{0}=>time={1}, value={2}", i + 1, data.Samples[i].TimeStamp, data.Samples[i].Value);
            }

            return sum / samplesPerChannel;
            // Clear the task
            // analogIn.Dispose();
            

            //data = reader.ReadWaveform(1);
            //return data.Samples[1].Value;

        }

        public void CloseChannel()
        {
            analogIn.Dispose();
        }
    }
}
