using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Student
    {
        //Declare Properties
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }

        //Constructors
        public Student(int studentID, string firstName, string lastName)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
            //make sure to initialize the course list
            this.Courses = new List<Course>();
        }
        //methods and functions
        public void PrintInfo()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
            Console.WriteLine("Student ID: {0}", this.StudentID);
            Console.WriteLine(string.Join("\n", this.Courses.Select(x => x.GetCourseInfo())));
            Console.WriteLine("GPA: {0}", this.Courses.Average(x => x.GradePoints));
        }
    }
}
