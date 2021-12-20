using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectEnumCasting.Models
{
    class Teacher : Person
    {
        public int Experiance { get; set; }
        public string Speciality { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Age}";
        }

        public static explicit operator Student(Teacher teacher)
        {
            Student student = new Student();
            student.Age = teacher.Age;
            student.Address = teacher.Address;
            return student;
        }
    }
}
