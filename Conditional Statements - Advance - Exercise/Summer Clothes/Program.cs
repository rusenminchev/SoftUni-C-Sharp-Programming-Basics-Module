using System;

namespace Summer_Clothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempInDegrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();



            if (time == "Morning")
            {
                if (tempInDegrees >= 10 && tempInDegrees <= 18)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (tempInDegrees > 18 && tempInDegrees <= 24)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your Shirt and Moccasins.");
                }
                if (tempInDegrees >= 25)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your T-Shirt and Sandals.");
                }
            }
            else if (time == "Afternoon")
            {
                if (tempInDegrees >= 10 && tempInDegrees <= 18)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your Shirt and Moccasins.");
                }
                else if (tempInDegrees > 18 && tempInDegrees <= 24)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your T-Shirt and Sandals.");
                }
                if (tempInDegrees >= 25)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your Swim Suit and Barefoot.");
                }
            }
            else if (time == "Evening")
            {
                if (tempInDegrees >= 10 && tempInDegrees <= 18)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your Shirt and Moccasins.");
                }
                else if (tempInDegrees > 18 && tempInDegrees <= 24)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your Shirt and Moccasins.");
                }
                if (tempInDegrees >= 25)
                {
                    Console.WriteLine($"It's {tempInDegrees} degrees, get your Shirt and Moccasins.");
                }
            }
        }
    }
}
