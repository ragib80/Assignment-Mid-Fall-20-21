using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Section
    {
        private string sectionName;

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
        public Department department { get; set; }
     
        private int courselist;

        public int CourseList
        {
            get { return courselist; }
            set { courselist = value; }
        }

        public Section()
        {
            
        }
        public Section(string sectionName)
        {
            this.sectionName = sectionName;
         
        }
        public void ShowInfo()
        {
            Console.WriteLine("Section Name : " + sectionName);
        
        }
    }
}
