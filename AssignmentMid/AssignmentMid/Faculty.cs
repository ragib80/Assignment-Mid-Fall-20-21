using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Faculty
    {
        private string facultyName;

        public string FacultyName
        {
            get { return facultyName; }
            set { facultyName = value; }
        }

        private string facultyId;

        public string FacultyId
        {
            get { return facultyId; }
            set { facultyId = value; }
        }
        public Faculty()
        {

        }
        public Faculty(string facultyName, string facultyId)
        {
            this.facultyName = facultyName;
            this.FacultyId = facultyId;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Faculty Name is : " + facultyName);
            Console.WriteLine("Faculty Id is : " + facultyId);
           
        }
    }
}
