using System;
using static OopBasic.Person;

namespace OopBasic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student1 student = new Student1() { Sex = "Male", Branch = "Math"};
            Student2 student2 = new Student2() { Sex = "Male", Branch = "Computer Science" };
            Teacher1 teacher = new Teacher1() { Sex = "Famale", Branch = "Physics" };

            Console.WriteLine("**STUDENT**");

            Console.WriteLine("Id: "+ student.Id);
            Console.WriteLine("Sex: "+ student.Sex);
            Console.WriteLine("Branch: "+ student.Branch);
            Console.WriteLine("Brand: "+ student.Brand);
            Console.WriteLine("Nationality: "+ student.Nationality);
            Console.WriteLine("ScholarShip: "+ student.Scholarship);

            Console.WriteLine("**STUDENT**");

            Console.WriteLine("Id: " + student2.Id);
            Console.WriteLine("Sex: " + student2.Sex);
            Console.WriteLine("Branch: " + student2.Branch);
            Console.WriteLine("Brand: " + student2.Brand);
            Console.WriteLine("Nationality: " + student2.Nationality);
            Console.WriteLine("ScholarShip: " + student2.Scholarship);

            Console.WriteLine("**TEACHER**");

            Console.WriteLine("Id: " + teacher.Id);
            Console.WriteLine("Sex: " + teacher.Sex);
            Console.WriteLine("Branch: " + teacher.Branch);
            Console.WriteLine("Brand: " + teacher.Brand);
            Console.WriteLine("Nationality: " + teacher.Nationality);


            Console.ReadLine();
        }
    }
}
