using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomparable_testing
{
    internal class Student : IComparable<Student>
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Average { get; set; }
        

        public Student(string name, int age, float avg) {
            Name = name;
            Age = age;
            Average = avg;
            Id = StudentID.Id++;
        }


        public int CompareTo(Student other)
        {
            if (other == null) return 1;

            Student otherStudent = other as Student;

            if (otherStudent != null)
                return this.Age.CompareTo(otherStudent.Age);

            else throw new ArgumentException("Object is not a student");
        }

    }
}
