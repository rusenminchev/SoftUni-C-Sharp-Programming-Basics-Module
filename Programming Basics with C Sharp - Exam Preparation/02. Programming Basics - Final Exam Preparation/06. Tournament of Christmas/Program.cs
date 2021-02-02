using System;
namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTournament = int.Parse(Console.ReadLine());

            double wonMoneyPerDay = 0;
            double wonMoneyTotal = 0;

            int counterWins = 0;
            int countetLoses = 0;

            int counterWinsTheDay = 0;
            int countetLosesTheDay = 0;

            for (int i = 1; i <= daysOfTournament; i++)
            {
                string sport = Console.ReadLine();
                while (sport != "Finish")
                {

                    string result = Console.ReadLine();

                    switch (result)
                    {
                        case "win":
                            counterWins++;
                            wonMoneyPerDay += 20;
                            break;

                        case "lose":
                            countetLoses++;
                            break;
                    }
                    sport = Console.ReadLine();
                }

                if (counterWins > countetLoses)
                {
                    counterWinsTheDay++;
                    wonMoneyPerDay += wonMoneyPerDay * 0.10;
                }
                else
                {
                    countetLosesTheDay++;
                }
                wonMoneyTotal += wonMoneyPerDay;

                wonMoneyPerDay = 0;
                counterWins = 0;
                countetLoses = 0;
            }

            if (counterWinsTheDay > countetLosesTheDay)
            {
                wonMoneyTotal += wonMoneyTotal * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {wonMoneyTotal:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {wonMoneyTotal:f2}");
            }
        }
    }
}
