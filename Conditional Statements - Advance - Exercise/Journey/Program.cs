using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string placeToVisit = "";
            string placeToStay = "";

            double spentMoney = 0;

            if (budget <= 100)
            {
                placeToVisit = "Bulgaria";
                if (season == "summer")
                {
                    placeToStay = "Camp";
                    spentMoney = budget * 0.30;
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    spentMoney = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                placeToVisit = "Balkans";
                if (season == "summer")
                {
                    placeToStay = "Camp";
                    spentMoney = budget * 0.40;
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    spentMoney = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                placeToVisit = "Europe";
                placeToStay = "Hotel";
                spentMoney = budget * 0.90;

            }
            
            Console.WriteLine($"Somewhere in {placeToVisit}");
            Console.WriteLine($"{placeToStay} - {spentMoney:f2}");
        }
        
    }
}
