using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            double result = 0.00;
            string evenOrOdd = "";

            switch (action)
            {
                case "+":
                result = n1 + n2;
            if (result % 2 == 0)
            {
                evenOrOdd = "even";
            }
            else
            {
                evenOrOdd = "odd";
            }
                    Console.WriteLine($"{n1} {action} {n2} = {result} - {evenOrOdd}");
                    break;
                case "-":
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";

                    }
                    Console.WriteLine($"{n1} {action} {n2} = {result} - {evenOrOdd}");
                    break;
                case "*":
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{n1} {action} {n2} = {result} - {evenOrOdd}");
                    break;
                case "/":
                    result = n1 / n2;
                    if (n1 == 0 || n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else 
                    {
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    
                    
                    break;
                case "%":
                    result = (n1 % n2);
                    if (n1 == 0 || n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    
                    break;
            }
            
        }
    }
}
