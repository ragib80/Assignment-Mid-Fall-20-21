using System;

namespace AssignmentMid
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Faculty of Science & Technology");
            Department d2 = new Department("Faculty of Engineering");
            Department d3 = new Department("Faculty of Arts & Social Sciences");
            Department d4 = new Department("Faculty of Business Administration");

            Course c1 = new Course("OOP1","CSE 2001",3,5);
            Course c2 = new Course("OOP2", "CSE 3101", 3, 5);
            Course c3 = new Course("PL1", "CSE 1001", 4, 6);
            Course c4 = new Course("Algorithm", "CSE 2101", 4, 6);
            Course c5 = new Course("OOAD", "CSE 3202", 3, 5);
            Course c6 = new Course("AI", "CSE 5001", 3, 5);
            Course c7= new Course("Accounting", "BBA 2001", 3, 3);
            Course c8 = new Course("DLC", "EEE 31100", 4, 6);
            Course c9 = new Course("BANGLADESH STUDIES", "FAST 11001",  3, 3);

            d1.AddCourse(c1, c2, c3, c4, c5, c6);
            d4.AddCourse(c7);
            d2.AddCourse(c8);
            d3.AddCourse(c9);

            d1.ShowInfo();
            d4.ShowInfo();
            d2.ShowInfo();
            d3.ShowInfo();

            Section s1 = new Section("Section i");
            Section s2 = new Section("Section j");
            Section s3 = new Section("Section k");
            Section s4 = new Section("Section l");
            Section s5 = new Section("Section m");

            Console.WriteLine("-------------------------sections----------------------------");

            c1.AddScetion(s1,s2);
            c1.ShowAllTheSections();
            c1.ShowInfo();


            c2.AddScetion(s2);
            c2.ShowAllTheSections();
            c2.ShowInfo();

            c3.AddScetion(s4,s5,s1);
            c3.ShowAllTheSections();
            c3.ShowInfo();

            c4.AddScetion(s3, s5);
            c4.ShowAllTheSections();
            c4.ShowInfo();

            c5.AddScetion(s1, s2,s3,s4);
            c5.ShowAllTheSections();
            c5.ShowInfo();

            c6.AddScetion(s5);
            c6.ShowAllTheSections();
            c6.ShowInfo();

            c7.AddScetion( s2, s3);
            c7.ShowAllTheSections();
            c7.ShowInfo();





            Console.WriteLine("-------------------------sections end----------------------------");
            Faculty f1 = new Faculty("Dr. Mahbubul Sayed", "18-254562-2");
            f1.AddCourse(c1, c2, c4,c5);
            f1.addCourseLoad(c1, s1);
          
            f1.addCourseLoad(c2, s2);
            
            f1.addCourseLoad(c4, s3);
            f1.addCourseLoad(c5, s5);

           

            f1.ShowInfo();
            f1.addCourseLoad(c5, s4);
            f1.ShowInfo();

            Console.WriteLine("********************");

            Faculty f2 = new Faculty("Dr Ashraf", "19-656232-2");
            f2.AddCourse(c1, c2);
            f2.addCourseLoad(c1, s1);
            f2.addCourseLoad(c2, s3);
            f2.ShowInfo();

            Faculty f3 = new Faculty("Abijit Bhowmik", "16-656232-2");
            f3.AddCourse(c4, c5, c6);
            f3.addCourseLoad(c4, s1);
            f3.addCourseLoad(c5, s4);
            f3.addCourseLoad(c6, s3);
            f3.ShowInfo();
            Console.WriteLine("--------------faculty info from course object----------------- ");
            c1.Faculty = f1;
            c1.Faculty.ShowInfo();
            c1.Faculty = f2;
            c1.Faculty.ShowInfo();
            Console.WriteLine("--------------------section ainfo from course object--------------- ");
            c2.Section = s1;
            c2.Section.ShowInfo();
            c2.Section = s2;
            c2.Section.ShowInfo();
            c2.Section = s3;
            c2.Section.ShowInfo();

            







        }
    }
}
