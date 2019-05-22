using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp6
{
    //program to convert from Celsius degrees to Kelvin and Fahrenheit
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the celsius:");
            int celsius = int.Parse(Console.ReadLine());

            Console.WriteLine("kelvin={0}", celsius + 273);
            Console.WriteLine("fahrenheit={0}", celsius * 18 / 10 + 32);

        }
    }
}
