using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double airplaneCapacity = double.Parse(Console.ReadLine());
            string suitcaseSize = Console.ReadLine();

            double lugageTotal = 0;
            int counter = 0;
            int suitcaseTotalQuantity = 0;

            while ( suitcaseSize != "End")
            {
                
                
                counter++;
                lugageTotal += double.Parse(suitcaseSize);

                if (counter == 3)
                {
                    lugageTotal += double.Parse(suitcaseSize) * 0.10;
                    counter = 0;
                }
                
                

                if (lugageTotal > airplaneCapacity)
                {
                    Console.WriteLine("No more space!");
                    
                    break;
                }
                suitcaseTotalQuantity++;
                suitcaseSize = Console.ReadLine();
            }

            if (suitcaseSize == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");   
            }
           Console.WriteLine($"Statistic: {suitcaseTotalQuantity} suitcases loaded.");
        }
    }
}
