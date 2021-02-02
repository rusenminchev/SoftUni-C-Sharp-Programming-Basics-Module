using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            int sum = 0;

            while (number != "Stop")
            {
                sum += int.Parse(number);
                number = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
