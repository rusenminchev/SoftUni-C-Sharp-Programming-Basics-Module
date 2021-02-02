using System;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             1. Броят на дните, в които тече кампанията – цяло число в интервала [0 … 365]
2. Броят на сладкарите – цяло число в интервала [0 … 1000]
3. Броят на тортите – цяло число в интервала [0… 2000]

© SoftUni – https://softuni.org. Copyrighted document. Unauthorized copy, reproduction or use is not permitted.
Follow us: Page 1 of 1

4. Броят на гофретите – цяло число в интервала [0 … 2000]
5. Броят на палачинките – цяло число в интервала [0 … 2000] */

            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double total = days * (cooks * ((cakes * 45) + (wafles * 5.80) + (pancakes * 3.20)));

            total = total - (total * 0.125);

            Console.WriteLine($"{total:f2}");


        }
    }
}
