using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Faculty:Teacher
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
        private int teachingHour;

        public int TeachingHour
        {
            get { return teachingHour; }
            set { teachingHour = value; }
        }
        Section[] sectionList;
        Course[] coursesList;
        
        private int sectionCount;
        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }
        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }



        public Faculty()
        {
            sectionList = new Section[100];
            coursesList = new Course[100];

        }
        public Faculty(string facultyName, string facultyId)
        {
            this.facultyName = facultyName;
            this.FacultyId = facultyId;
            sectionList = new Section[100];
            coursesList = new Course[100];
        }
        public void ShowInfo()
        {
            
            Console.WriteLine("Faculty Name is : " + facultyName);
            Console.WriteLine("Faculty Id is : " + facultyId);
            Console.WriteLine("Weekly Teaching Hours : " + teachingHour + " hours");
            Console.WriteLine("\ncurrently "+FacultyName+" taking those courses  : ");
            ShowCourse();

        }
       
        
        public void ShowSection()
        {
            for(int i=0;i< SectionCount; i++)
            {
                sectionList[i].ShowInfo();
            }
        }
        public void AddCourse(params Course[] courses )
        {
            foreach (var s in courses)
            {
                if (courseCount < 5)
                {
                    this.coursesList[courseCount++] = s;
                }
                else
                {
                    Console.WriteLine("Sorry too many couse already added! ");
                }
            }
        }
        public void ShowCourse()
        {
            ShowSection();
            for (int i = 0; i < courseCount; i++)
            {
                coursesList[i].ShowInfo();
            }
            
        }
        public void addCourseLoad(Course c, Section s)
        {
            if ((this.TeachingHour + c.CourseWeeklyHour) <= 21)
            {
                this.TeachingHour += c.CourseWeeklyHour;
                sectionList[sectionCount++] = s;
                
            }
            else
            {
                Console.WriteLine("Faculty Cannot have classes more than 21 hour weekly");
                return;
            }
        }

    }
}

