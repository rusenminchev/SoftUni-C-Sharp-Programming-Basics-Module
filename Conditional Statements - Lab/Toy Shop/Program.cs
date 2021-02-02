using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Пъзел - 2.60 лв.
 Говореща кукла - 3 лв.
 Плюшено мече - 4.10 лв.
 Миньон - 8.20 лв.
 Камионче - 2 лв. */

            double vacantionPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minnions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double total = puzzles * 2.60 + dolls * 3 + bears * 4.1 + minnions * 8.2 + trucks * 2;

            int numberOfToys = puzzles + dolls + bears + minnions + trucks;



    
            if (numberOfToys >= 50)
            {
                total = total - total * 0.25;
            }

            total = total - total * 0.10;

            if (total >= vacantionPrice)
            {
                Console.WriteLine($"Yes! {total - vacantionPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacantionPrice - total:F2} lv needed. ");
            }
        }
    }
}
