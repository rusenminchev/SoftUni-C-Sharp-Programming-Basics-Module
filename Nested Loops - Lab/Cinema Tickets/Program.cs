using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

            int counterBookedSeats = 0;
            int counterStudent = 0;
            int counterStandard = 0;
            int counterKids = 0;

            while (true)
            {
                string comandOrMovieName = Console.ReadLine();
                if (comandOrMovieName == "Finish")
                {
                    break;
                }
                int freeSeats = int.Parse(Console.ReadLine());
                
                

                while (counterBookedSeats < freeSeats)
                {
                    string comandOrTypeOfTicket = Console.ReadLine();
                    if (comandOrTypeOfTicket == "End")
                    {
                        break;
                    }
                    if (comandOrTypeOfTicket == "student")
                    {
                        counterStudent++;
                    }
                    else if (comandOrTypeOfTicket == "standard")
                    {
                        counterStandard++;
                    }
                    else if (comandOrTypeOfTicket == "kid")
                    {
                        counterKids++;
                    }
                    counterBookedSeats++;

                }

                double percent = counterBookedSeats * 1.0 / freeSeats * 100;

                Console.WriteLine($"{comandOrMovieName} - {percent:f2}% full.");
                counterBookedSeats = 0;
            }

            int totalBookedSeats = counterStudent + counterStandard + counterKids;
            double percentStudent = counterStudent * 1.0 / totalBookedSeats * 100;
            double percentStandard = counterStandard * 1.0 / totalBookedSeats * 100;
            double percentKids = counterKids * 1.0 / totalBookedSeats * 100;


            Console.WriteLine($"Total tickets: {totalBookedSeats}");
            Console.WriteLine($"{percentStudent:f2}% student tickets.");
            Console.WriteLine($"{percentStandard:f2}% standard tickets.");
            Console.WriteLine($"{percentKids:f2}% kids tickets.");
        }
    }
}
