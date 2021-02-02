using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMeasure = Console.ReadLine();
            string outputMeasure = Console.ReadLine();

            switch (inputMeasure)
            {
                case "m" : 
                    number /= 1;
                    break;
                case "mm":
                    number /= 1000;
                        break;
               case "cm":
                    number /= 100;
                        break;

             }
            switch (outputMeasure)
            {
                case "m": number *= 1;
                    break;
                case "mm": number *= 1000;
                    break;
                case "cm": number *= 100;
                    break;
            }


            Console.WriteLine($"{number:f3}");
            
        }
    }
}
