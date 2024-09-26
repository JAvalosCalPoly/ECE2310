using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ptompt
            Console.WriteLine("Hello, what is the temperature today in Fahrenheit?");
            //read imput
            String Dat = Console.ReadLine();
            Double Temp = Convert.ToDouble( Dat );
            //convert to celcius
            double NTemp = (Temp - 32)* 5/9;
            //round
            Double RTemp = Math.Round(NTemp, 1);
            //output
            Console.WriteLine("That is {0} degrees Celcius", RTemp);
            Console.Read();
        }
    }
}
