using System;

namespace Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGuests = int.Parse(Console.ReadLine());
            double couvert = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (numOfGuests >= 10 && numOfGuests <= 15)
            {
                couvert -= couvert * 0.15;
            }
            else if (numOfGuests > 15 && numOfGuests <= 20)
            {
                couvert -= couvert * 0.20;
            }
            else if (numOfGuests > 20)
            {
                couvert -= couvert * 0.25;
            }

            double cakePrice = budget * 0.10;

            double totalPrice = (numOfGuests * couvert) + cakePrice;

            double diff = Math.Abs(budget - totalPrice);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"It is party time! {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {diff:f2} leva needed.");
            }
        }
    }
}
