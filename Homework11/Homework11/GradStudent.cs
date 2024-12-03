using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class GradStudent : Student
    {
        private string Degree;
        private string Institution;
        public string degree
        {
            get { return degree; } set { degree = value; }
        }
        public string institution
        {
            get { return institution; } set { institution = value; }
        }
        public GradStudent(string name, int age, string id, string degreeType, string institution) : base(name, age, id)
        {
            Degree = degreeType;
            Institution = institution;
        }
        public override string ToString()
        {
            return $"{Name} has a {Degree} obtained at {Institution}.";
        }
    }
}
