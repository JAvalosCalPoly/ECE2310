using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type a number: ");
                //Convert answer to int32
                bool ver = Int32.TryParse(Console.ReadLine(), out int uin);
                if (ver == true)
                {
                    //output
                    if (uin % 2 == 0)
                    {
                        Console.WriteLine("number is Even!\n");
                    }
                    else
                    {
                        Console.WriteLine("number is Odd!\n");
                    }
                }
                //when a non-number is typed
                else
                {
                    Console.WriteLine("Please Enter a valid number...\n");
                }
            }
        }
    }
}
