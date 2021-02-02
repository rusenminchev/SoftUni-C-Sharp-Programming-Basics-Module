using System;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double currentSavings = double.Parse(Console.ReadLine());

            int days = 0;
            int daysOfSpending = 0;

            while (currentSavings < vacationPrice && daysOfSpending < 5)
            {
                string action = Console.ReadLine();
                double moneySpentOrSaved = double.Parse(Console.ReadLine());


                if (action == "save")
                {
                    currentSavings += moneySpentOrSaved;
                    daysOfSpending = 0;
                }
                else if (action == "spend")
                {
                    currentSavings -= moneySpentOrSaved;
                    daysOfSpending += 1;

                    if (currentSavings < 0)
                    {
                        currentSavings = 0;
                    }
                }
                days++;
            }
            if (daysOfSpending == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
                return;
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        
        }
    }
}
