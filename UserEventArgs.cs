using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dx2Timer
{
    public class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(string msg)
        {
            Message = msg;
        }

        public string Message { get; set; }
    }

    public class MoonAgeEventArgs : EventArgs
    {
        public MoonAgeEventArgs(MoonAges age)
        {
            MoonAge = age;
        }

        public MoonAges MoonAge { get; set; }
    }
}
