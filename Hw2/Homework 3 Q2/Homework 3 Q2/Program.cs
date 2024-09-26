using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AppRunState = 1;
            int Pupilcnt = 0;
            while (AppRunState == 1)
            {
                //input validation
                Console.Write($"\nGrades processed: {Pupilcnt}");
                Console.Write("\nEnter the grade(0-100): ");
                int grd = 0;
                bool ver = Int32.TryParse(Console.ReadLine(), out grd);

                while (!(ver && grd >= 0 && grd <= 100))
                {
                    if (!ver)
                        Console.WriteLine("Invalid number...");
                    else if (grd < 0)
                        Console.WriteLine("Invalid number, grade cannot be negative...");
                    else
                        Console.WriteLine("Invalid, Grade cannot be over 100...");
                    ver = Int32.TryParse(Console.ReadLine(), out grd);
                }

                if (ver && grd >= 0 && grd <= 100) //valid inputs only
                {
                    switch (grd / 10)
                    {
                        case 6:
                            Console.WriteLine("Letter Grade: D");
                            Pupilcnt++;
                            break;
                        case 7:
                            Console.WriteLine("Letter Grade: C");
                            Pupilcnt++;
                            break;
                        case 8:
                            Console.WriteLine("Letter Grade: B");
                            Pupilcnt++;
                            break;
                        case 9:
                        case 10:
                            Console.WriteLine("Letter Grade: A");
                            Pupilcnt++;
                            break;
                        default:
                            Console.WriteLine("Letter Grade: F");
                            Pupilcnt++;
                            break;
                    }
                }
                
                int endCon = 1;
                while (endCon > 0)
                {
                Console.WriteLine("Would you like to continue?");
                Console.WriteLine("(1) yes\n(2) no");
                    bool UserendConver = Int32.TryParse(Console.ReadLine(), out int UserendCon);
                    
                    if (UserendConver)
                    {
                        if (UserendCon == 1)
                        {
                            AppRunState = 1;
                            endCon = 0;
                        }
                        else if (UserendCon == 2)
                        {
                            AppRunState = 0;
                            endCon = 0;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option...");
                        } 
                    }
                    else 
                    { 
                        Console.WriteLine("Please enter a valid option...");
                        endCon = 1; 
                    }

                }
                if (AppRunState == 0)
                {
                    Console.WriteLine("Goodbye, Press any key to exit to exit.");
                    Console.ReadKey();
                }
            }
        }
    }
}
