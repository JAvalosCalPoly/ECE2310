using System;
using System.Linq;

namespace Utilities
{
    public class Util
    {
        public static void GetInput(string item, double lower, ref double x)
        {
            bool valid;
            do
            {
                Console.Write($"Please enter the {item}: ");
                valid = double.TryParse(Console.ReadLine(), out x);
                if (!valid || x < lower)
                {
                    Console.WriteLine("\nInvalid input, please try again.");
                }
            } while (!valid || x < lower);
        }
        public static void GetInput(string item, double lower, ref int x)
        {
            bool valid;
            do
            {
                Console.Write($"Please enter the {item}: ");
                valid = int.TryParse(Console.ReadLine(), out x);
                if (!valid || x < lower)
                {
                    Console.WriteLine("\nInvalid input, please try again.");
                }
            } while (!valid || x < lower);
        }
        public static void GetInput(string item, double lower, double higher, ref double x)
        {
            bool valid;
            do
            {
                Console.Write($"Please enter the {item}: ");
                valid = double.TryParse(Console.ReadLine(), out x);
                if (!valid || x < lower || x > higher)
                {
                    Console.WriteLine("\nInvalid input, please try again.");
                }
            } while (!valid || x < lower || x > higher);
        }
        public static T Highest<T>(T[] array) where T : IComparable<T> => array.Max();
        public static T Lowest<T>(T[] array) where T : IComparable<T> => array.Min();
    }
}