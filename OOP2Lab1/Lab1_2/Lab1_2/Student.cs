using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Student
    {
        public string name;
        public int age;
        public Student()
        { }
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return this.name + " " + this.age; 
        }
    }
}
