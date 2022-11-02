using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    internal class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door Up");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door Down");
        }
    }
}
