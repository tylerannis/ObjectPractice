using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Course
    {
        //declare the properties and variables
        public string Name { get; set; }

        public int GradePoints { get; set; }

        //declare a custom property for lettergrade
        private string _letterGrade;

        public string LetterGrade
        {
            get { return _letterGrade; }
            set 
            {
               _letterGrade = value.ToUpper(); 
            //lettergrade was set, update the gradepoints
               if (_letterGrade == "A")
               {
                   this.GradePoints = 4;
               }
               else if (_letterGrade == "B")
               {
                   this.GradePoints = 3;
               }
               else if (_letterGrade == "C")
               {
                   this.GradePoints = 2;
               }
               else if (_letterGrade == "D")
               {
                   this.GradePoints = 1;
               }
               else
               {
                   this.GradePoints = 0;
               }
            }
        }
        //make your cunstructors, don't need a data type it's just public then the name
        public Course(string name, string grade)
        {
            this.Name = name;
            this.LetterGrade = grade;
            //the setter for letterGrade will automatically set the GradePoints
        }

            //Methods and/or Functions
        public string GetCourseInfo()
        {
            return this.Name + " " + this.LetterGrade + " " + this.GradePoints;
        }
        
        

    }
}
