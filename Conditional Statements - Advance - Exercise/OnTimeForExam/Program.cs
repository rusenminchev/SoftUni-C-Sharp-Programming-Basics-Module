using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());

            if (hourOfExam == hourOfArrival)
            {
                Console.WriteLine("On time");
            }
            else if ((hourOfExam < hourOfArrival) || (minutesOfArrival > minutesOfExam + 30) )
            {
                double minutesLate = minutesOfExam + minutesOfArrival;
                Console.WriteLine("Late");
                Console.WriteLine($"{minutesLate} minutes after the start” ");
            }
            else if ((hourOfExam > hourOfArrival) || (minutesOfArrival >= minutesOfExam - 30))
            {
                double minutesEarly = minutesOfArrival - minutesOfExam;
                Console.WriteLine("Early");
                Console.WriteLine($"{minutesEarly} minutes before the start” ");
            }
        }
    }
}
