using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            // Print the first 30 numbers
            for (int i = 1; i <= 30; i++)
            {
                // Convert number to string
                String FString = Fibo(i).ToString();
                // To Center the numbers
                int CenteringVal = (10 - FString.Length)/2;
                // Print string formatted
                Console.Write(FString.PadLeft(CenteringVal + FString.Length).PadRight(10));
                count++;
                // After printing 5 numbers start a new row
                if (count % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
        static int Fibo(int n)
        {
            // If 1 or 2 (1st and 2nd)
            if (n == 1 || n == 2)
                return 1;
            // Fibonacci Sequance Formula
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
