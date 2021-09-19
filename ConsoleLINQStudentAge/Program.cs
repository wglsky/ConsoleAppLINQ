﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLINQStudentAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Query!");

            List<Student> stuList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            var LinqRes = from stu in stuList
                          where stu.Age >= 18 && stu.Age <= 20
                          select stu.StudentName;
            foreach (var item in LinqRes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
