using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0;

            double finalGrade = 0;
            int currentGrade = 1;


            while (currentGrade <= 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00 && grade <= 6.00)
                {
                    finalGrade += grade;
                }
                else if (grade >= 2.00 && grade < 4.00)
                {
                    currentGrade--;
                }    
                currentGrade++;
            }
            double averageGrade = finalGrade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
