using System;

namespace Exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFails = int.Parse(Console.ReadLine());

            int fails = 0;
            int exerciseCounter = 0;
            double totalGrade = 0;
            string lastProblem = "";

            while (fails < numberOfFails)
            {
               string theNameOfTheExercise = Console.ReadLine();
                if (theNameOfTheExercise == "Enough")
                {
                    double averageGrade = totalGrade / exerciseCounter;
                    
                    Console.WriteLine($"Average score: {averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {exerciseCounter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    return;
                }
                int grade = int.Parse(Console.ReadLine());
                
                totalGrade += grade;
                exerciseCounter++;
                lastProblem = theNameOfTheExercise;

                if (grade >= 2 && grade <= 4)
                {
                    fails++;
                    if (fails == numberOfFails)
                    {
                        Console.WriteLine($"You need a break, {fails} poor grades.");
                        return;
                    }
                }   
            }
            Console.WriteLine($"You need a break, {fails} poor grades.");
        }
    }
}
