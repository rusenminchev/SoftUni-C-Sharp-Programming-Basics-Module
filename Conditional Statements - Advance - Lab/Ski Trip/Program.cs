using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            if (typeOfRoom == "room for one person")
            {
                double price = (dayOfStay - 1) * 18;
                    if (feedback == "positive")
                    {
                        price = price + (price * 0.25);
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (feedback == "negative")
                    {
                        price = price - (price * 0.10);
                        Console.WriteLine($"{price:f2}");
                    }
                

            }
            else if (typeOfRoom == "apartment")
            {
                if (dayOfStay < 10)
                {
                    double price = (dayOfStay - 1) * 25;
                    double discountedPrice = price - (price * 0.30);
                    if (feedback == "positive")
                    {
                        discountedPrice = discountedPrice + (discountedPrice * 0.25);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }
                    else if (feedback == "negative")
                    {
                        discountedPrice = discountedPrice - (discountedPrice * 0.10);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }

                }
                else if (dayOfStay >= 10 && dayOfStay <= 15)
                {
                    double price = (dayOfStay - 1) * 25;
                    double discountedPrice = price - (price * 0.35);
                    if (feedback == "positive")
                    {
                        discountedPrice = discountedPrice + (discountedPrice * 0.25);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }
                    else if (feedback == "negative")
                    {
                        discountedPrice = discountedPrice - (discountedPrice * 0.10);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }

                }
                else if (dayOfStay > 15)
                {
                    double price = (dayOfStay - 1) * 25;
                    double discountedPrice = price - (price * 0.50);
                    if (feedback == "positive")
                    {
                        discountedPrice = discountedPrice + (discountedPrice * 0.25);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }
                    else if (feedback == "negative")
                    {
                        discountedPrice = discountedPrice - (discountedPrice * 0.10);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }

                }
            }
            else if (typeOfRoom == "president apartment")
            {
                if (dayOfStay < 10)
                {
                    double price = (dayOfStay - 1) * 35;
                    double discountedPrice = price - (price * 0.10);
                    if (feedback == "positive")
                    {
                        discountedPrice = discountedPrice + (discountedPrice * 0.25);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }
                    else if (feedback == "negative")
                    {
                        discountedPrice = discountedPrice - (discountedPrice * 0.10);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }

                }
                else if (dayOfStay >= 10 && dayOfStay <= 15)
                {
                    double price = (dayOfStay - 1) * 35;
                    double discountedPrice = price - (price * 0.15);
                    if (feedback == "positive")
                    {
                        discountedPrice = discountedPrice + (discountedPrice * 0.25);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }
                    else if (feedback == "negative")
                    {
                        discountedPrice = discountedPrice - (discountedPrice * 0.10);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }


                }
                else if (dayOfStay > 15)
                {
                    double price = (dayOfStay - 1) * 35;
                    double discountedPrice = price - (price * 0.20);
                    if (feedback == "positive")
                    {
                        discountedPrice = discountedPrice + (discountedPrice * 0.25);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }
                    else if (feedback == "negative")
                    {
                        discountedPrice = discountedPrice - (discountedPrice * 0.10);
                        Console.WriteLine($"{discountedPrice:f2}");
                    }

                }
            }

        }
    }
}
