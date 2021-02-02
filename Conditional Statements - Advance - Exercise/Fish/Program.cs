using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (numberOfPeople > 0 && numberOfPeople <= 6)
                    {
                        price *= 0.90;
                    }
                    else if (numberOfPeople > 7 && numberOfPeople <= 11)
                    {
                        price *= 0.85;
                    }
                    else if (numberOfPeople > 12)
                    {
                        price *= 0.75;
                    }

                    break;

                case "Summer":
                    price = 4200;
                    if (numberOfPeople > 0 && numberOfPeople <= 6)
                    {
                        price *= 0.90;
                    }
                    else if (numberOfPeople > 7 && numberOfPeople <= 11)
                    {
                        price *= 0.85;
                    }
                    else if (numberOfPeople > 12)
                    {
                        price *= 0.75;
                    }

                    break;

                case "Autumn":
                    price = 4200;
                    if (numberOfPeople > 0 && numberOfPeople <= 6)
                    {
                        price *= 0.90;
                    }
                    else if (numberOfPeople > 7 && numberOfPeople <= 11)
                    {
                        price *= 0.85;
                    }
                    else if (numberOfPeople > 12)
                    {
                        price *= 0.75;
                    }

                    break;

                case "Winter":
                    price = 2600;
                    if (numberOfPeople > 0 && numberOfPeople <= 6)
                    {
                        price *= 0.90;
                    }
                    else if (numberOfPeople > 7 && numberOfPeople <= 11)
                    {
                        price *= 0.85;
                    }
                    else if (numberOfPeople > 12)
                    {
                        price *= 0.75;
                    }

                    break;
            }
            if (numberOfPeople % 2 == 0 && season != "Autumn")
            {
                price *= 0.95;
            }

            double moneyLeft = budget - price;
            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            { 
             Console.WriteLine($"Not enough money! You need {(moneyLeft * -1):f2} leva.");
            }
        }
    }
}
