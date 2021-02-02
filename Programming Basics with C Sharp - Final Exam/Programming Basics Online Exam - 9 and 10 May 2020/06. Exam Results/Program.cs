using System;
using System.Data;
using System.Drawing;

namespace _06._Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int points = 0;
            double pointsSum = 0;
            double grade = 0;

            while (command != "Midnight")
            {
               

                for (int i = 1; i <= 6; i++)
                {
                    points = int.Parse(Console.ReadLine());
                    if (points < 0)
                    {
                        Console.WriteLine($"{command} was cheating!");
                        grade = 0;
                        pointsSum = 0;
                        break;
                    }

                    pointsSum += points;
                }

                pointsSum = Math.Floor(pointsSum * 1.0 / 600 * 100);
                grade = pointsSum * 0.06;


                if (grade > 0 && grade < 5)
                {
                    if (grade < 3)
                    {
                        grade = 2.00;

                    }
                    Console.WriteLine($"{command} - {grade:f2}");
                    
                }
                
                else if (grade >= 5)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("|   CERTIFICATE   |");
                    Console.WriteLine($"|    {grade:f2}/6.00    |");
                    Console.WriteLine("===================");
                    Console.WriteLine($"Issued to {command}");
                   

                }

                command = Console.ReadLine();
                grade = 0;
                pointsSum = 0;
            }
        }
    }
}
