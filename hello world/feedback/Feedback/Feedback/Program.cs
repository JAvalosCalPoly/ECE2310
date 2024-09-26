using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string v = Console.ReadLine();
            Console.Write("hello, your name is ");
            Console.Write(v);
            Console.WriteLine("!");
        }
    }
}
