using System;

namespace _04._Exam_Retention
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());


            double studentsLeft = students;
            double combackStuds = 0;
            int counter = 0;

            for (int i = 1; i <= seasons; i++)
            {
                counter++;
                studentsLeft = Math.Ceiling(studentsLeft * (90 * 1.0 / 100));
                studentsLeft = Math.Ceiling(studentsLeft * (90 * 1.0 / 100));
                studentsLeft = Math.Ceiling(studentsLeft * (80 * 1.0 / 100));
                if (counter == 3)
                {
                    combackStuds = Math.Ceiling(studentsLeft * (15 * 1.0 / 100));
                    counter = 0;
                }
                else
                {
                    combackStuds = Math.Ceiling(studentsLeft * (5 * 1.0 / 100));
                }
                studentsLeft = studentsLeft + combackStuds;
                
                
            }

            Console.WriteLine($"Students: {studentsLeft}");
        }
    }
}
