using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());
                sum = sum + nextNum;
            }

            Console.WriteLine(sum);
        }
    }
}
