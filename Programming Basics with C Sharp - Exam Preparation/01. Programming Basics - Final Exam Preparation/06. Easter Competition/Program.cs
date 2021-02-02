using System;
using System.Drawing;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKozunaks = int.Parse(Console.ReadLine());

            int currentTotalPoints = 0;

            int bestScore = int.MinValue;
            string nameOFTheWinner = "";

            for (int i = 1; i <= numOfKozunaks; i++)
            {
                string nameOfTheChef = Console.ReadLine();
                string points = Console.ReadLine();

                while (points != "Stop")
                {

                    currentTotalPoints += int.Parse(points);
                    
                    points = Console.ReadLine();
                    
                }

                Console.WriteLine($"{nameOfTheChef} has {currentTotalPoints} points.");
                if (currentTotalPoints > bestScore)
                {
                    bestScore = currentTotalPoints;
                    nameOFTheWinner = nameOfTheChef;
                    Console.WriteLine($"{nameOfTheChef} is the new number 1!");
                }

                
                currentTotalPoints = 0;
            }

            Console.WriteLine($"{nameOFTheWinner} won competition with {bestScore} points!");


        }
    }
}
