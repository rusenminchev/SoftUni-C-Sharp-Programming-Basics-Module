using System;

namespace New_House_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double roses = 5;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;

            double totalPrice = 0;

            switch (typeOfFlower)
            {
                case "Roses":
                    totalPrice = quantity * roses;
                    if (quantity > 80)
                    {
                        totalPrice *= 0.90;
                    }

                    break;

                case "Dahlias":
                    totalPrice = quantity * dahlias;
                    if (quantity > 90)
                    {
                        totalPrice *= 0.85;
                    }

                    break;

                case "Tulips":
                    totalPrice = quantity * tulips;
                    if (quantity > 80)
                    {
                        totalPrice *= 0.85;
                    }

                    break;

                case "Narcissus":
                    totalPrice = quantity * narcissus;
                    if (quantity < 120)
                    {
                        totalPrice *= 1.15;
                    }

                    break;

                case "Gladiolus":
                    totalPrice = quantity * gladiolus;
                    if (quantity < 80)
                    {
                        totalPrice *= 1.20;
                    }

                    break;
            }

            double moneyLeft = budget - totalPrice;

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {typeOfFlower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(moneyLeft * -1):F2} leva more.");
            }

        }
    }
}
