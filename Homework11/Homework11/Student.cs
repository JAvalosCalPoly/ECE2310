using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
        // Base class
        public class Student
        {
            protected string Name;
            protected int Age;
            protected string ID;
            public string name
            {
                get { return Name; }
                set { Name = value; }
        }
        public int age
        {
            get { return Age; }
            set { if (value < 0)
                    age = value;
                else
                    age = 0;
            }
        }
        public string id
        {
            get { return ID; }
            set { ID = value; }
        }

        public Student(string name, int age, string id)
            {
                Name = name;
                Age = age;
                ID = id;
            }

        public override string ToString()
        {
            return $"{Name} Whose ID is {ID} and is {Age.ToString()} years old.";
        }
    }
    }
