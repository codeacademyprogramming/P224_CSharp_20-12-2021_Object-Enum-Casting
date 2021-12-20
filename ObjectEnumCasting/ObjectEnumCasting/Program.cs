using System;
using ObjectEnumCasting.Models;

namespace ObjectEnumCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object Enum
            //Human human = new Human();
            //human.Name = "Altan";
            //human.SurName = "Ibrahimli";
            //Console.WriteLine(human);


            //foreach (var item in Enum.GetValues(typeof(Position)))
            //{
            //    Console.WriteLine($"{(int)item} {item}");
            //}

            //string[] arr = Enum.GetNames(typeof(Position));

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"{i} {arr[i]}");
            //}

            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine((Position)num);

            //switch (num)
            //{
            //    case (int)Position.Director:
            //        Console.WriteLine("2000 AZN");
            //        break;
            //    case (int)Position.Muhasib:
            //        Console.WriteLine("500");
            //        break;
            //    case (int)Position.Hr:
            //        Console.WriteLine("1000");
            //        break;
            //    case (int)Position.Muhavuize:
            //        Console.WriteLine("5000");
            //        break;
            //    case (int)Position.IT:
            //        Console.WriteLine("1000000000");
            //        break;
            //    default:
            //        Console.WriteLine("Daxil Etdiyniz Reqem Yanlisdir");
            //        break;
            //}
            #endregion

            #region Boxing UnBoxing
            //Student student1 = new Student();
            //student1.Age = 25;
            //student1.Education = "IT";
            //Student student2 = new Student();
            //student2.Age = 19;
            //student2.Education = "Design";
            //Student student3 = new Student();
            //student3.Age = 15;
            //student3.Education = "Bekar";

            //Teacher teacher1 = new Teacher();
            //teacher1.Age = 19;
            //teacher1.Experiance = 4;
            //Teacher teacher2 = new Teacher();
            //teacher2.Age = 30;
            //teacher2.Experiance = 1;
            //Teacher teacher3 = new Teacher();
            //teacher3.Age = 25;
            //teacher3.Experiance = 3;

            //Human[] humen = { student1, student2, student3, teacher1, teacher2, teacher3 };

            //Human[] newhumen = GetThanGrater20(humen);

            //foreach (var item in newhumen)
            //{
            //    Console.WriteLine(item);
            //}

            //UnBoxing
            //Danger Way
            //Console.WriteLine((Teacher)newhumen[0]);


            //First Safe Way
            //Console.WriteLine(newhumen[0] is Student);
            //foreach (Human human in newhumen)
            //{
            //    if (human is Teacher)
            //    {
            //        Teacher teacher = (Teacher)human;
            //        Console.WriteLine($"Teacher: {teacher.Age} {teacher.Experiance}");
            //    }
            //    else
            //    {
            //        Student student = (Student)human;
            //        Console.WriteLine($"Student: {student.Age} {student.Education}");
            //    }
            //}

            //Second Safe Way
            //Student student = newhumen[0] as Student;
            //Console.WriteLine(student);

            //foreach (Human human in newhumen)
            //{
            //    Teacher teacher = human as Teacher;
            //    if (teacher != null)
            //    {
            //        Console.WriteLine($"Teacher: {teacher} {teacher.Experiance}");
            //    }
            //    else
            //    {
            //        Student student = human as Student;
            //        Console.WriteLine($"Student: {student.Age} {student.Education}");
            //    }
            //}
            #endregion

            #region Impicity Explicity
            //Student student = new Student();
            //student.Address = "Baki";
            //student.Age = 25;
            //student.Position = "Junior Developer";
            //student.Salary = 250;

            //Teacher teacher = /*(Teacher)*/student;
            //Student student1 = (Student)teacher;

            //Console.WriteLine(teacher.Age+" "+teacher.Address+" "+teacher.Position+" "+teacher.Salary);

            #endregion

            int a = 5;
            int b = 7;

            string test = "";
            String str = new String("");
            Console.WriteLine(a + b);

            Student student1 = new Student();
            Student student2 = new Student();

            Teacher teacher = new Teacher();

            Console.WriteLine(student1 + student2);
            Console.WriteLine(student1 - student2);
            Console.WriteLine(student1 > student2);

            Console.WriteLine(student1 + teacher);
        }


        #region Boxing UnBoxing
        //static Student[] GetThanGrater20(Student[] students)
        //{
        //    Student[] newStudents = new Student[0];
        //    foreach (Student item in students)
        //    {
        //        if (item.Age > 20)
        //        {
        //            Array.Resize(ref newStudents, newStudents.Length + 1);
        //            newStudents[newStudents.Length - 1] = item;
        //        }
        //    }

        //    return newStudents;
        //}

        //static Teacher[] GetThanGrater20(Teacher[] teachers)
        //{
        //    Teacher[] newTeachers = new Teacher[0];
        //    foreach (Teacher item in teachers)
        //    {
        //        if (item.Age > 20)
        //        {
        //            Array.Resize(ref newTeachers, newTeachers.Length + 1);
        //            newTeachers[newTeachers.Length - 1] = item;
        //        }
        //    }

        //    return newTeachers;
        //}

        //static Human[] GetThanGrater20(Human[] humen)
        //{
        //    Human[] newhumen = new Human[0];
        //    foreach (Human item in humen)
        //    {
        //        if (item.Age > 20)
        //        {
        //            Array.Resize(ref newhumen, newhumen.Length + 1);
        //            newhumen[newhumen.Length - 1] = item;
        //        }
        //    }

        //    return newhumen;
        //}
        #endregion
    }

    #region ObjectEnum
    //enum Position
    //{
    //    Director=200,
    //    Muhasib,
    //    Hr,
    //    Muhavuize,
    //    IT
    //}

    //class Human
    //{
    //    public string Name { get; set; }
    //    public string SurName { get; set; }

    //    public string Info()
    //    {
    //        return $"{Name} {SurName}";
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Name} {SurName}";
    //    }
    //}
    #endregion
}
