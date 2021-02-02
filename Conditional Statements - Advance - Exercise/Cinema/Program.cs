using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
//            Premiere – премиерна прожекция, на цена 12.00 лева.
// Normal – стандартна прожекция, на цена 7.50 лева.
// Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            string projecitonType = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int seats = r * c;

            switch (projecitonType)
            {
                case "Premiere":
                    double incomePremiere = seats * 12.00;
                    Console.WriteLine($"{incomePremiere:f2} leva");
                    break;
                case "Normal":
                    double incomeNormal = seats * 7.50;
                    Console.WriteLine($"{incomeNormal:f2} leva");
                    break;
                case "Discount":
                    double incomeDiscount = seats * 5.00;
                    Console.WriteLine($"{incomeDiscount:f2} leva");
                    break;


            }


        }
    }
}
