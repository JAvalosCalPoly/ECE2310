using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class UnderGraduate : Student
    {
        private string Class;
        public string classs
        {
            get { return Class; }
            set { Class = value; }
        }
        public UnderGraduate(string name, int age, string id, string classification)
           : base(name, age, id)
        {
            Class = classification;
        }
        public override string ToString()
        {
            return $"{Name} is a {Class}";
        }
    }
}
