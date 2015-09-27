using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lightSwitch = true;
            bool lamp = true;
            Console.WriteLine(lightSwitch && lamp);
            Console.WriteLine(lightSwitch || lamp);
            Console.WriteLine(!lightSwitch);
            Console.WriteLine(lightSwitch ^ lamp);
            Console.ReadLine();


        }
    }
}
