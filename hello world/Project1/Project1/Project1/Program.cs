using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("~~~~~~Welcome To Hypotenuse Solver~~~~~~\n");
            Console.Write("Imput the first leg: ");            //Prompt
            Double L1 = Double.Parse(Console.ReadLine());      //Reads and converts to double
            Console.Write("Imput the second leg: ");           //Prompt
            Double L2 = Double.Parse(Console.ReadLine());      //Reads and converts to double
            Double LegSum = Math.Pow(L1 , 2) + Math.Pow(L2 , 2); //sums the squares of both variables
            Double HypInter = Math.Sqrt(LegSum);                    //Square roots the sum
            Double Hyp = Math.Round(HypInter,3);                 //Rounds to 3 places
            Console.WriteLine("The Hypotenuse of your triangle is {0}.", Hyp);
                //end
                Console.Read();
        }
    }
}
