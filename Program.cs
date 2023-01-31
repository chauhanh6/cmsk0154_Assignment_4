namespace cmsk0154_Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>
            {
                new Course
                {
                    CourseID = 1,
                    Code = "CMSK154",
                    Name = "C# Fundamentals"
                },
                new Course
                {
                    CourseID = 2,
                    Code = "CMSK152",
                    Name = "Javascript Fundamentals"
                }
            };

            List<Student> students = new List<Student>
            {
                new Student
                {
                    StudentID = 1,
                    FirstName = "John",
                    LastName = "Jones"
                },
                new Student
                {
                    StudentID = 2,
                    FirstName = "Karen",
                    LastName = "Night"
                },
                new Student
                {
                    StudentID = 3,
                    FirstName = "Allan",
                    LastName = "Anderson"
                },
                new Student
                {
                    StudentID = 4,
                    FirstName = "Gerry",
                    LastName = "Garvis"
                }
            };

            courses[0].Students.Add(students[0]);
            courses[0].Students.Add(students[1]);

            courses[1].Students.Add(students[2]);
            courses[1].Students.Add(students[3]);

            Console.WriteLine("Course List");
            Console.WriteLine("---------------------------------------------");




            foreach (var course in courses)
            {
                Console.WriteLine($"{course.CourseID} {course.Code} {course.Name}");
                
                foreach (var student in course.Students)
                {
                    Console.WriteLine($"      {student.StudentID} {student.FirstName} {student.LastName}");
              
                }

                
            }
        }
    }

}
