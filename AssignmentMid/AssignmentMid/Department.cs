using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Department
    {
        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        private int numberOfCourse;

        public int NumberOFCourse
        {
            get { return numberOfCourse; }
            set { numberOfCourse = value; }
        }

        Course[] courseList;
        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }

        public Department()
        {
            courseList = new Course[100];
        }
        public Department(string departmentName)
        {
            this.departmentName = departmentName;
            courseList = new Course[100];
        }

        public void ShowInfo()
        {
            Console.WriteLine("Department Name is : " + departmentName);
            for (int i = 0; i < CourseCount; i++)
            {
                courseList[i].ShowInfo();
            }
        }

        public void AddCourse(params Course[] courses)
        {
            foreach (var c in courses)
            {
                if (courseCount < 100)
                {
                    courseList[courseCount++] = c;
                }
            }

            

        }
       
    }
}
