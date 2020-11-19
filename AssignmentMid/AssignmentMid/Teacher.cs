using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Teacher
    {
        private string teacherName;

        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }
        private string teacherId;

        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }


        public Section section { get; set; }
       public Teacher()
        {

        }
        public Teacher(string teacherName, string teacherId)
        {
            this.teacherName = teacherName;
            this.teacherId = teacherId;
        }
         public void ShowInfo()
        {
            Console.WriteLine("teacher name : " + teacherName);
            Console.WriteLine("teacher id: " + teacherId);
        }
    }
}
