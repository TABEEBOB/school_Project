using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolProject
{
    class Course
    {
        public String courseName;
        public int courseId;

        public Course() // empty constructor 
        {
            this.courseName = " ";
            this.courseId = 0;
        }
        //constructor with parameters
        public Course(String courseName, int courseId)
        {
            this.courseName = courseName;
            this.courseId = courseId;
        }
        //get and set methods for all variables 
        public String getCourseName()
        {
            return courseName;
        }
        public int getCourseId()
        {
            return courseId;
        }
        public void setCourseName(String courseName)
        {
            this.courseName = courseName;
        }
        public void setCourseId(int courseId)
        {
            this.courseId = courseId;
        }

        //display method prints output on console
        public void displayCourse()
        {
            Console.WriteLine("Course Name: " + getCourseName());
            Console.WriteLine("Course ID: " + getCourseId());
        }

    }
}
