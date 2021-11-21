using System;
using System.Collections.Generic;
using System.Text;

namespace VeeamLab2
{
    class CustomEventArgs : EventArgs
    {
        public string Message { get; set; }

        public CustomEventArgs(string message)
        {
            Message = message;
        }
    }
}
