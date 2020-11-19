using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Course
    {
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private string courseId;

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        private int courseCradit;

        public int CourseCradit
        {
            get { return courseCradit; }
            set { courseCradit = value; }
        }
        private int courseWeeklyHour;

        public int CourseWeeklyHour
        {
            get { return courseWeeklyHour; }
            set { courseWeeklyHour = value; }
        }
        Section[] sectionList;
        
        private int numberOfSection;

        public int NumberOfSection
        {
            get { return numberOfSection; }
            set { numberOfSection = value; }
        }
        private Section section;

        public Section Section
        {
            get { return section; }
            set { section = value; }
        }
        private Faculty faculty;

        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }


        public Course()
        {
            sectionList = new Section[100];
            
        }
        public Course(string courseName,string courseId, int courseCradit, int courseWeeklyHour)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCradit = courseCradit;
            this.courseWeeklyHour= courseWeeklyHour;
            sectionList = new Section[100];
           
        }

        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course ID : " + courseId);
            Console.WriteLine("Course Cradit : " + courseCradit);
            Console.WriteLine("Course Weekly Hour : " + courseWeeklyHour);
            Console.WriteLine("\n");

        }

        public void AddScetion(params Section[] sections)
        {
            foreach (var s in sections)
            {
                if (numberOfSection < 20)
                {
                    this.sectionList[numberOfSection++] = s;
                }
                else
                {
                    Console.WriteLine("Section is full!! sorry can not add more section: ");
                }
            }
        }

        public void ShowAllTheSections()
        {
            
            for (int i = 0; i < numberOfSection; i++)
            {
                sectionList[i].ShowInfo();
            }
        }




    }
}
