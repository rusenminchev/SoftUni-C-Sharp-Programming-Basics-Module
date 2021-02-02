using System;

namespace AlkoholShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.Цена на уискито в лева – реално число в интервала[0.00 … 10000.00]
 2.Количество на бирата в литри – реално число в интервала[0.00 … 1 0000.00]
 3.Количество на виното в литри – реално число в интервала[0.00 … 10000.00]
 4.Количество на ракията в литри – реално число в интервала[0.00 … 10000.00]
 5.Количество на уискито в литри – реално число в интервала[0.00 … 10000.00]*/


            double whiskeyPrice = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakia = double.Parse(Console.ReadLine());
            double quantityWhiskey = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - rakiaPrice * 0.4;
            double beerPrice = rakiaPrice - rakiaPrice * 0.8;

            double total = (quantityBeer * beerPrice) + (quantityWine * winePrice) + (quantityRakia * rakiaPrice) + (quantityWhiskey * whiskeyPrice);
            Console.WriteLine($"{total:f2}");



        }
    }
}
