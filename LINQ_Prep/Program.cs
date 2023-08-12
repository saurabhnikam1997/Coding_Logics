using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Prep
{
    class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee{Name="Kim", Age=23},
                new Employee{Name="Kim1", Age=24},
                new Employee{Name="Kim2", Age=25},
                new Employee{Name="Kim3", Age=26},
                new Employee{Name="Kim4", Age=27},
                new Employee{Name="Kim5", Age=27},
                new Employee{Name="Kim6", Age=28},
                new Employee{Name="Kim7", Age=28},
                new Employee{Name="Kim8", Age=29},
                new Employee{Name="Kim9", Age=20},
                new Employee{Name="Kim10", Age=21},
                new Employee{Name="Kim22", Age=26},
                new Employee{Name="Kim23", Age=26},
                new Employee{Name="Kim24", Age=23},
                new Employee{Name="Kim26", Age=23},
                new Employee{Name="Kim32", Age=35},
                new Employee{Name="Kim31", Age=33},
                new Employee{Name="Kim34", Age=43},
                new Employee{Name="Kim33", Age=53},
                new Employee{Name="Kim55", Age=63},
                new Employee{Name="Kim66", Age=43},
                new Employee{Name="Kim76", Age=13},
                new Employee{Name="Kimfg", Age=23}
            };

            IEnumerable<Employee> listEmp = (from emp in empList orderby emp.Name ascending where emp.Age < 40 select emp).Take(8);

           //var emp1 = empList.Last();
            //Print each emp 
            foreach (var emp in listEmp)
            {
                Console.WriteLine($"{emp.Name} ... {emp.Age}");
            }
            Console.ReadLine();
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };

            //Get only short words
            var shortWords = from word in words where word.Length <= 5 select word;
            var sw =  from word in words where word.Length == 5 select word;


            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };
            IEnumerable<int> cntList = from score in scores where score < 90 select score;


            //Print each word out
            foreach (var word in sw)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();


            //var list = (from t in ctn.Items
            //            where t.DeliverySelection == true && t.Delivery.SentForDelivery == null
            //            orderby t.Delivery.SubmissionDate
            //            select t).Take(5);

            string[] words1 = { "hello", "wonderful", "LINQ", "beautiful", "world", "hello", "wonderful", "LINQ", "beautiful", "world", "hello", "wonderful", "LINQ", "beautiful", "world", "hello", "wonderful", "LINQ", "beautiful", "world" };

            var ls = (from e in words1 select e).Take(10);

            foreach (var word in ls)
            {
                int cnt = 1;
                Console.WriteLine($"{cnt+1} ... {word}");
                
            }

            // Sample data
            List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "John", CourseId = 101 },
            new Student { StudentId = 2, Name = "Alice", CourseId = 102 },
            new Student { StudentId = 3, Name = "Bob", CourseId = 101 },
            new Student { StudentId = 4, Name = "Eva", CourseId = 103 },
        };

            List<Course> courses = new List<Course>
        {
            new Course { CourseId = 101, CourseName = "Math" },
            new Course { CourseId = 102, CourseName = "Science" },
            new Course { CourseId = 103, CourseName = "History" },
        };

            // Join students and courses based on CourseId
            var query = from student in students
                        join course in courses on student.CourseId equals course.CourseId
                        select new
                        {
                            student.StudentId,
                            student.Name,
                            course.CourseName
                        };

            var q = from std in students
                    join course in courses on std.CourseId equals course.CourseId orderby std.Name
                    select new
                    {
                        std.StudentId,
                        std.Name,
                        course.CourseName
                    };

            // Print the result
            foreach (var result in query)
            {
                Console.WriteLine($"StudentID: {result.StudentId}, Name: {result.Name}, Course: {result.CourseName}");
            }
        

        Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
