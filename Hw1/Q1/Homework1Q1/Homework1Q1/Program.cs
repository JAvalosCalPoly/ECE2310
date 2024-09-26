using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt
            Console.WriteLine("~~~~~~~~~Mile to Kilometer~~~~~~~~~");
            //user imputs number of miles
            Console.Write("Miles: ");
            Double Mi = Double.Parse(Console.ReadLine());
            //convert to Kilometer (1 mile = 1.609344 Km)
            Double Km = Mi * 1.609344;
            Km = Math.Round(Km, 2);
            //display
            Console.WriteLine("{0} miles is {1} Kilometers.", Mi, Km);
            Console.Read();
        }
    }
}
