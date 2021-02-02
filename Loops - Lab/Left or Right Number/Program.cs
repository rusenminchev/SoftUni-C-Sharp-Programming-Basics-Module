using System;

namespace Left_or_Right_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2 * int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i<= 2)
                {
                    leftSum += number;
                }
                if (i > 2 && n <= 4)
                {
                    rightSum += number;
                }

            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
