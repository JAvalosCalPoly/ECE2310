using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass_excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1-99999: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int d1 = x % 10;                        //int d1 = (x / 10000) % 10;   //int d1 = x % 10;
            int d2 = (x % 100) / 10;                                        //int d2 = (x / 1000) & 10;   //int d2 = x % 100 /10;
            int d3 = (x % 1000) / 100;                                                              //int d3 = (x / 100) & 10;    //int d3 = (x % 1000 )/100;
            int d4 = (x % 10000) /1000;                                                                                        //int d4 = (x / 10) & 10;  //int d4 = (x/10)&10;
            int d5 = x / 10000;                                                                                                               //int d5 = (x & 10);    //int d5 = x / 10000;
            Console.WriteLine("The digits are: {0}, {1}, {2}, {3}, and {4}.", d5, d4, d3, d2, d1);
            Console.Read();
        }
    }
}
