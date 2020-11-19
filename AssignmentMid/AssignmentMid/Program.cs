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

            d1.AddCourse(c1, c2, c3, c4, c5, c6);
            d4.AddCourse(c7);

            d1.ShowInfo();
            d4.ShowInfo();

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

            Console.WriteLine("-------------------------sections end----------------------------");



        }
    }
}
