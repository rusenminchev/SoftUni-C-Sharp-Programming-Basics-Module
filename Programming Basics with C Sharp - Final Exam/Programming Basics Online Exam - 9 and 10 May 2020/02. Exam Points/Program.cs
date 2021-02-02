using System;
using System.Net.NetworkInformation;

namespace _02._Exam_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTheProblem = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string nameOfTheCourse = Console.ReadLine();

            double calculatedPoints = 0;

            if (numOfTheProblem == 1)
            {
                switch (nameOfTheCourse)
                {
                    case "Basics":

                        calculatedPoints = points * (8 * 1.0 / 100);
                        calculatedPoints *= 0.80;
                        break;

                    case "Fundamentals":
                        calculatedPoints = points * (11 * 1.0 / 100);
                        break;

                    case "Advanced":
                        calculatedPoints = points * (14 * 1.0 / 100);
                        calculatedPoints += calculatedPoints * 0.20;
                        break;
                }
            }
            else if (numOfTheProblem == 2)
            {
                switch (nameOfTheCourse)
                {
                    case "Basics":
                        calculatedPoints = points * (9 * 1.0 / 100);
                        break;

                    case "Fundamentals":
                        calculatedPoints = points * (11 * 1.0 / 100);
                        break;

                    case "Advanced":
                        calculatedPoints = points * (14 * 1.0 / 100);
                        calculatedPoints += calculatedPoints * 0.20;
                        break;
                }
            }
            else if (numOfTheProblem == 3)
            {
                switch (nameOfTheCourse)
                {
                    case "Basics":
                        calculatedPoints = points * (9 * 1.0 / 100);
                        break;

                    case "Fundamentals":
                        
                        calculatedPoints = points * (12 * 1.0 / 100);
                        break;

                    case "Advanced":
                        calculatedPoints = points * (15 * 1.0 / 100);
                        calculatedPoints += calculatedPoints * 0.20;
                        break;
                }
            }
            else if (numOfTheProblem == 4)
            {
                switch (nameOfTheCourse)
                {
                    case "Basics":
                        calculatedPoints = points * (10 * 1.0 / 100);
                        break;

                    case "Fundamentals":
                        calculatedPoints = points * (13 * 1.0 / 100);
                        
                        break;

                    case "Advanced":
                        calculatedPoints = points * (16 * 1.0 / 100);
                        calculatedPoints += calculatedPoints * 0.20;
                        break;
                }
            }

            Console.WriteLine($"Total points: {calculatedPoints:f2}");
        }
    }
}
