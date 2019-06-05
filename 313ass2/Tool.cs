using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _313ass2
{
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

    public class ToolChangedEventArgs : EventArgs
    {
        public int button { get; set; }
    }
}
