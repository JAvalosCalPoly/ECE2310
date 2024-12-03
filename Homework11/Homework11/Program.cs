using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John Doe", 20, "S12345");
            GradStudent gradStudent = new GradStudent("Eggs Benedict", 24, "G12345", "M.S.", "MIT");
            UnderGraduate underGrad = new UnderGraduate("Pan Cake", 19, "U12345", "Sophomore");
            Console.WriteLine("Student Info:");
            Console.WriteLine(student.ToString());
            Console.WriteLine();

            Console.WriteLine("Graduate Student Info:");
            Console.WriteLine(gradStudent.ToString());
            Console.WriteLine();

            Console.WriteLine("Undergraduate Info:");
            Console.WriteLine(underGrad.ToString());
        }
    }
}
