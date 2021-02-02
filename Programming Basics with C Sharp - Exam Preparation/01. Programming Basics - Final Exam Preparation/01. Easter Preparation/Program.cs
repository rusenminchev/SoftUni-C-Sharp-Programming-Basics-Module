using System;
using System.Transactions;
using System.Xml.Schema;

namespace Exam_Preparation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunak = int.Parse(Console.ReadLine());
            int setsOf12Eggs = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());


            double priceOfEggPaint = (setsOf12Eggs * 12) * 0.15;

            double totalPrice = (kozunak * 3.20) + (setsOf12Eggs * 4.35) + priceOfEggPaint + (kgCookies * 5.40);

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
