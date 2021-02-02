using System;

namespace _03._Exam_Categories1
{
    class Program
    {
        static void Main(string[] args)
        {
            int difficulty = int.Parse(Console.ReadLine());
            int complexity = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());


            int anymin = int.MinValue;
            int anymax = int.MaxValue;

            if (difficulty >= 80 && complexity >= 80 && pages >= 8)
            {
                Console.WriteLine("Legacy");
                
            }
            else if (difficulty >= 80 && complexity <= 10 && pages >= anymin)
            {
                Console.WriteLine("Master");
                
            }
            else if (difficulty >= anymin && complexity >= 50 && pages >= 2)
            {
                Console.WriteLine("LHard");
                
            }
            else if (difficulty >= anymin && complexity >= anymin && pages >= anymin)
            {
                Console.WriteLine("Regular");
                
            }
            else if (difficulty <= 30 && complexity >= anymin && pages <= anymin)
            {
                Console.WriteLine("Easy");
               
            }
            else if (difficulty <= 10 && complexity >= anymin && pages >= anymin)
            {
                Console.WriteLine("Elementary");
              
            }
            
        }
    }
}
