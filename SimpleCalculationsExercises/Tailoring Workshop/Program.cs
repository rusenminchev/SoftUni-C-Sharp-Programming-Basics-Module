using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Потребителят въвежда 3 числа, по едно на ред:
            Брой правоъгълни маси – цяло число в интервала[0...500]
            Дължина на правоъгълните маси в метри – реално число в интервала[0.00...3.00]
            Широчина на правоъгълните маси в метри – реално число в интервала[0.00...3.00] */

            int quantity = int.Parse(Console.ReadLine());
            double lenthOfTheTables = double.Parse(Console.ReadLine());
            double widthOfTheTables = double.Parse(Console.ReadLine());

            double rectangleTableClothArea = quantity * (lenthOfTheTables + 2 * 0.30) * (widthOfTheTables + 2 * 0.30);
            double squareTableClothArea = quantity * (lenthOfTheTables / 2) * (lenthOfTheTables / 2);

            double total = (rectangleTableClothArea * 7 + squareTableClothArea * 9);

            double usdToBgn = total * 1.85;

            Console.WriteLine($"{total:f2} USD");
            Console.WriteLine($"{usdToBgn:f2} BGN");




        }
    }
}
