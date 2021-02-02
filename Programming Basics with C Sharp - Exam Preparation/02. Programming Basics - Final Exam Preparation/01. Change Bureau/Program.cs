using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yun = double.Parse(Console.ReadLine());
            double commicionPercent = double.Parse(Console.ReadLine());

            double euroToBgn = 1.95;
            double usdToBgn = 1.76;

            bitcoin = bitcoin * 1168;
            yun = (yun * 0.15) * usdToBgn;

            double sumEuro = ((bitcoin + yun) * 1.0) / euroToBgn;

            double commision = sumEuro * commicionPercent / 100;

            sumEuro -= commision;



            Console.WriteLine($"{sumEuro:f2}");

        }
    }
}
