using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string reachedSteps = Console.ReadLine();
            

            int dailyGoal = 10000;
            int sumOfTheSteps = 0;

            while (reachedSteps != "Going home")
            {
                sumOfTheSteps += int.Parse(reachedSteps);
                if (sumOfTheSteps >= dailyGoal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    return;
                }
                reachedSteps = Console.ReadLine();
            }

            sumOfTheSteps += int.Parse(Console.ReadLine());

            if (sumOfTheSteps >= dailyGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                int diff = dailyGoal - sumOfTheSteps;
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}
