using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Area;
            Double pi = Math.PI;
            int Inp;
            int ProgramRunCondition = 1;
            Console.WriteLine("~~~~~Area Calculator~~~~~");
            while (ProgramRunCondition == 1)
            {
                Console.Write("\nWhich Shape would you like to calculate?");
                Console.Write("\nCircle (1), Rectangle (2), or the surface area of a Cylinder (3)? (4) to Exit ");
                bool UserVer = Int32.TryParse(Console.ReadLine(), out int UserInput);
                if (UserVer == true)
                {
                    Inp = 0;
                    switch(UserInput)
                    {
                        case 1:
                            while (Inp == 0)
                            {
                                Console.Write("\nRadius: ");
                                bool Rver = Double.TryParse(Console.ReadLine(),out double R);
                                if (Rver == true)
                                {
                                    Area =Math.Round(pi * Math.Pow(R, 2) , 3);
                                    Inp = 1;
                                    Console.Write($"\nThe area of the circle is {Area}.");
                                }
                                else { Console.WriteLine("\nPlease enter a valid radius..."); }
                            }break;

                        case 2:
                            int Winp = 0;
                            while (Inp == 0)
                            {
                                Console.Write("\nLength: ");
                                bool Lver = Double.TryParse(Console.ReadLine(),out double L);
                                if (Lver == true)
                                {
                                    while (Inp == 0 && Winp == 0)
                                    {
                                        Console.Write("\nWidth: ");
                                        bool Wver = Double.TryParse(Console.ReadLine(),out double W);
                                        if (Wver == true)
                                        {
                                            Area = Math.Round(L * W, 3);
                                            Console.Write($"\nThe area of the rectangle is {Area}");
                                            Inp = 1;
                                            Winp = 1;
                                        }
                                        else { Console.WriteLine("\nPlease enter a valid Width..."); }
                                    }
                                }
                                else { Console.WriteLine("\nPlease enter a valid length..."); }

                            }break;

                        case 3:
                            int Hinp = 0;
                            while(Inp == 0)
                            {
                                Console.Write("\nRadius: ");
                                bool Rcver = Double.TryParse(Console.ReadLine(), out double Rc);
                                if (Rcver == true)
                                {
                                    while(Inp == 0 && Hinp == 0)
                                    {
                                        Console.Write("\nHeight: ");
                                        bool Hver = Double.TryParse(Console.ReadLine(), out double H);
                                        if (Hver == true)
                                        {
                                            Area = Math.Round(((2 * pi) * Rc * H) + (2 * pi * Math.Pow(Rc, 2)),3);
                                            Console.Write($"\nThe surface area of the cylinder is {Area}");
                                            Inp = 1;
                                            Hinp = 1;
                                        }
                                        else { Console.Write("\nPlease enter a valid height"); }
                                    }
                                }
                                else { Console.WriteLine("\nPlease enter a valid radius..."); }
                            }break;
                        case 4:
                            ProgramRunCondition = 0;
                            Console.WriteLine("Thank you, good bye...");
                            break;

                    }
                }
                else 
                {
                    Console.WriteLine("Please enter a valid option...");
                }

            }
        }

    }
}
