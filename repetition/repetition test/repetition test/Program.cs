using System;

namespace repetition_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prod = 1, j = 1 ;
            do
            {
                Console.Write($"{prod} x {j} = ");
                prod *= j;
                j++;
                Console.WriteLine(prod.ToString());
            } while (j <= 15);
            Console.WriteLine(prod);
            Console.ReadLine();
        }
    }
}
