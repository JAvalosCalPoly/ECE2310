using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ecercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            ////Prompt and Validation for size of Class   
            //Console.WriteLine("What is the size of the class?");
            //bool Kver = Int32.TryParse(Console.ReadLine(), out int K);
            ////loops until valid number is inputted
            //while (!Kver || K <= 0)
            //{
            //    if (!Kver)
            //        Console.WriteLine("Please enter a number...");
            //    else
            //        Console.WriteLine("please enter a positive number");
            //    Console.WriteLine("What is the size of the class?");
            //    Kver = Int32.TryParse(Console.ReadLine(), out K);
            //}
            //Console.WriteLine($"Class Size {K}.");
            //
            int K = 0;
            bool Kver;
            int Scor;
            Random nj = new Random();
            Scor = nj.Next(0, 101);
            Console.WriteLine($"This score is {Scor}");
        
        Console.Read();
        }
    }
}
