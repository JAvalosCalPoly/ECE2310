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

            //Prompt and Validation for size of Class   
            Console.WriteLine("What is the size of the class?");
            Console.Write("--> ");
            bool Kver = Int32.TryParse(Console.ReadLine(), out int K);
            //loops until valid number is inputted
            while (!Kver || K <= 0)
            {
                if (!Kver)
                    Console.WriteLine("Please enter a number...");
                else
                    Console.WriteLine("please enter a positive number");
                Console.WriteLine("What is the size of the class?");
                Kver = Int32.TryParse(Console.ReadLine(), out K);
            }
            Console.WriteLine($"Class Size: {K}");
            Console.WriteLine("________________________________");
            int Scor;
            int Ave = 0;
            int HSc = 0;
            Random nj = new Random();
            //Assigns random grades
            for (int i = 1; i <= K; i++)
            {
                Scor = nj.Next(60, 101);
                Console.WriteLine($"The score of student #{i} is {Scor}");
                Ave += Scor;
                if (i == 1)
                    HSc = Scor;
                if (HSc < Scor)
                    HSc = Scor;
            }
            //computes averages
            Console.WriteLine("--------------------------------");
            Ave /= K;
            Console.WriteLine($"The average is {Ave}");
            Console.WriteLine($"The highest score is {HSc}");
            Console.WriteLine("--------------------------------");

            Console.Read();
        }
    }
}
