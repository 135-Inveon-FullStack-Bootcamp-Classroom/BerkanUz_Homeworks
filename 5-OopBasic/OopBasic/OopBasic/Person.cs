using System;
using System.Collections.Generic;
using System.Text;

namespace OopBasic
{
    public class Person
    {
        public interface IPerson
        {
            public string Sex { get; set; }
            public string Branch { get; set; }
        }

        public class Student : IPerson
        {
            public string Sex { get; set; }
            public string Branch { get; set; }
            public string Brand = "Student";

        }

        public class Teacher : IPerson
        {
            public string Sex { get; set; }
            public string Branch { get; set; }
            public string Brand = "Teacher";
        }


        public class Student1 : Student
        {
            public int Id = 1;
            public string Name = "Ahmet";
            public string Nationality = "Turkey";
            public string Scholarship = "Yes";
        }

        public class Student2 : Student
        {
            public int Id = 2;
            public string Name = "Mehmet";
            public string Nationality = "Canada";
            public string Scholarship = "No";

        }

        public class Teacher1 : Teacher
        {
            public int Id = 3;
            public string Name = "Ayse";
            public string Nationality = "El Salvador";
        }
    }
}
