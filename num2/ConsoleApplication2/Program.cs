using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Birth Year");
            Console.ReadLine();


           TimeSpan BirthYear = TimeSpan.Parse(Console.ReadLine());

            TimeSpan age =  TimeSpan.Parse("2015") - BirthYear;
           TimeSpan y = TimeSpan.Parse("1994");
            
            if 
            (y >= age)

            { Console.WriteLine("OK!"); }

            else
            { Console.WriteLine("NO!!"); }



                
            
        }
    }
}
