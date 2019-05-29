using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;

namespace ReadWrite
{
    class DigitalO
    {
        //Create a new task for digital channel
        Task digitalOut = new Task();
        //Create a new single cahnnel writer
        DigitalSingleChannelWriter writer;

        public void OpenChannel(string portLine, string portName)
        {
            //Create a new digital output channel called "Doutport0"
            digitalOut.DOChannels.CreateChannel(portLine, //Assigned line
                portName, // Assigned name for cahnnel
                ChannelLineGrouping.OneChannelForAllLines); //grouping feature of the lines

            //Initialise the single channel writer and assigned stream of channel to it
            writer = new DigitalSingleChannelWriter(digitalOut.Stream);
        }

        public void WriteData(int length)
        {
            //call WriteSignleSamplePort method to write the data to the channel
            if (writer != null)
                writer.WriteSingleSamplePort(true, (UInt32)length);
        }

    }
}