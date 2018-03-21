using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    delegate void Sequence(int i);
    class Collection
    {
        public Sequence sequence;
        static Random rd = new Random();
        public int size;
        public List<Student> students;
        public Collection()
        {
            this.size = 0;
        }
        public Collection(int size)
        {
            this.students = new List<Student>();
            this.size = size;
            for (int i = 0; i < this.size; i++)
                this.students.Add(new Student(Faker.Name.FullName(), rd.Next(17, 35)));
        }
        public string MinAge()
        {
            if (this.students != null)
            {
                int min = this.students.Min(p => p.age);
                return min.ToString();
            }
            return "";
        }
        public string MaxAge()
        {
            if (this.students != null)
            {
                int max = this.students.Max(p => p.age);
                return max.ToString();
            }
            return "";
        }
        public IEnumerable<Student> SequenceList(int seq)
        {
            IEnumerable<Student> sortedStudents = null;
            if (this.students != null)
            {
                sortedStudents = from student in this.students
                                                orderby seq*student.age
                                                select student;
            }
            return sortedStudents;
        }
    }
}
