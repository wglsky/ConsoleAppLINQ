using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLINQStudentAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++++ LINQ Query Syntax +++++++++++");

            List<Student> stuList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
                new Student() { StudentID = 5, StudentName = "Lily" , Age = 15 }
            };

            var LinqRes = from stu in stuList
                          where stu.Age >= 18 && stu.Age <= 20
                          select stu.StudentName;
            foreach (var item in LinqRes)
            {
                Console.WriteLine(item);
            }

            // LINQ Method Syntax
            Console.WriteLine("+++++++++++++ LINQ Method Syntax +++++++++++");
            var result = stuList.Where(s => s.Age >= 18 && s.Age <= 20);
            foreach (Student student in result)
            {
                Console.WriteLine(student.StudentName);
            }

            // Return a List of the students
            Console.WriteLine("+++ LINQ Method Syntax -Return List<Student> +++++");
            List<Student> list = stuList.Where(s => s.Age >= 18 && s.Age <= 20).ToList<Student>();

            foreach (Student student in list)
            {
                Console.WriteLine(student.StudentName);
            }

            // Return odd student
            Console.WriteLine("+++++ Return odd students +++++");
            var oddStudents = stuList.Where((s, i) => (i % 2 != 0));
            foreach (var item in oddStudents)
            {
                Console.WriteLine(item.StudentName);
            }

            // Using multiple where clause
            Console.WriteLine("+++++++Using multiple where clause ++++++++++");
            var multipleWhereRes = from s in stuList
                                   where s.Age >= 18 && s.Age <= 20
                                   where s.StudentName.Contains("m")
                                   select s;

            foreach (Student stu in multipleWhereRes)
            {
                Console.WriteLine(stu.StudentName);
            }

        }
    }
}
