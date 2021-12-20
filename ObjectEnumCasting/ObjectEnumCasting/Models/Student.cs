using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectEnumCasting.Models
{
    class Student : Person
    {
        public string Education { get; set; }
        public string GroupNo { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Age}";
        }

        public static implicit operator Teacher(Student student)
        {
            Teacher teacher = new Teacher();
            teacher.Age = student.Age;
            teacher.Address = student.Address;
            teacher.Position = "Midle Developer";
            teacher.Salary = 1000;
            return teacher;
        }

        //public static explicit operator Teacher(Student student)
        //{
        //    Teacher teacher = new Teacher();
        //    teacher.Age = student.Age;
        //    teacher.Address = student.Address;
        //    return teacher;
        //}

        public static int operator +(Student stu1, Student stu2)
        {
            return stu1.Age + stu2.Age;
        }

        public static int operator +(Student stu1, Teacher stu2)
        {
            return stu1.Age + stu2.Age;
        }

        public static double operator -(Student stu1, Student stu2)
        {
            return stu1.Salary - (double)stu2.Age;
        }

        public static bool operator >(Student stu1, Student stu2)
        {
            return stu1.Salary > stu2.Salary;
        }

        public static bool operator <(Student stu1, Student stu2)
        {
            return false;
        }

        public static bool operator >=(Student stu1, Student stu2)
        {
            return true;
        }

        public static bool operator <=(Student stu1, Student stu2)
        {
            return true;
        }

        public static bool operator !=(Student stu1, Student stu2)
        {
            return true;
        }

        public static bool operator ==(Student stu1, Student stu2)
        {
            return true;
        }
    }
}
