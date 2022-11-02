using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    internal class Light
    {
        public void On()
        {
            Console.WriteLine("Turn on the light");
        }

        public void Off()
        {
            Console.WriteLine("Turn off the light");
        }
    }
}
