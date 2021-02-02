using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string period = Console.ReadLine();
            int numOfNight = int.Parse(Console.ReadLine());

            double pricePerNight = 0;

            switch (destination)
            {
                case "France":

                    switch (period)
                    {
                        case "21-23":
                            pricePerNight = 30;
                            break;
                        case "24-27":
                            pricePerNight = 35;
                            break;
                        case "28-31":
                            pricePerNight = 40;
                            break;

                    }
                    break;

                case "Italy":

                    switch (period)
                    {
                        case "21-23":
                            pricePerNight = 28;
                            break;
                        case "24-27":
                            pricePerNight = 32;
                            break;
                        case "28-31":
                            pricePerNight = 39;
                            break;

                    }
                    break;

                case "Germany":

                    switch (period)
                    {
                        case "21-23":
                            pricePerNight = 32;
                            break;
                        case "24-27":
                            pricePerNight = 37;
                            break;
                        case "28-31":
                            pricePerNight = 43;
                            break;

                    }
                    break;

            }

            double totalPrice = numOfNight * pricePerNight;

            Console.WriteLine($"Easter trip to {destination} : {totalPrice:f2} leva.");

        }
    }
}
