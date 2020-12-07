using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student gloria = new Student();
           
            gloria.Name = "Gloria";
            gloria.StudentId = 007;
            gloria.NumberOfCredits = 1;
            gloria.Gpa = 4.0;

            Console.WriteLine(gloria.Name);
            Console.WriteLine(gloria.StudentId);
            Console.WriteLine(gloria.NumberOfCredits);
            Console.WriteLine(gloria.Gpa);
        }
    }
}
