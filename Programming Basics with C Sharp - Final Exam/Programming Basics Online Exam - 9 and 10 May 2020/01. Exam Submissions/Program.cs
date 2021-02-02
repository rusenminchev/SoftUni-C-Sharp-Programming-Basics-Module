using System;
using System.Xml.Schema;

namespace _01._Exam_Submissions
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            int numOfProblems = int.Parse(Console.ReadLine());



            double sumsPefStud = Math.Ceiling(numOfProblems * 2.8);

            double extraSubmission = numOfProblems / 3;

            double numOfSubmissions = numOfStudents * (sumsPefStud + extraSubmission);


            double memo = Math.Ceiling(numOfSubmissions * 1 / 10);
            double memoryNeeded = 5 * memo;

            Console.WriteLine($"{memoryNeeded} KB needed");
            Console.WriteLine($"{numOfSubmissions} submissions");




        }
    }
}
