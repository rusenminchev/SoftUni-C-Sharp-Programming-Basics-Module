using System;

namespace GRaduation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0;

            int fail = 0;
            int currentGrade = 1;

            double totalGrade = 0;

            while (currentGrade <= 12)
            {
                grade = double.Parse(Console.ReadLine());
                
                if (grade >= 2.00 && grade < 4.00)
                {
                    fail++;
                    
                    if (fail > 1)
                    {
                        currentGrade-=1;
                        Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
                        return;
                    }
                }
                else if (grade >= 4.00 && grade <= 6.00)
                { 
                    totalGrade += grade;
                }
                currentGrade++;
            }

            double averageGrade = totalGrade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
