using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGroups = int.Parse(Console.ReadLine());

            int peopleSum = 0;

            int musala = 0;
            int monblanc = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;


            for (int i = 1; i <= numOfGroups; i++)
            {
                int numOfPeoplePerGroup = int.Parse(Console.ReadLine());

                peopleSum += numOfPeoplePerGroup;

                if (numOfPeoplePerGroup >= 1 && numOfPeoplePerGroup <= 5)
                {
                    musala += numOfPeoplePerGroup;
                }
                else if (numOfPeoplePerGroup >= 6 && numOfPeoplePerGroup <= 12)
                {
                    monblanc += numOfPeoplePerGroup;
                }
                else if (numOfPeoplePerGroup >= 13 && numOfPeoplePerGroup <= 25)
                {
                    kilimandjaro += numOfPeoplePerGroup;
                }
                else if (numOfPeoplePerGroup >= 26 && numOfPeoplePerGroup <= 40)
                {
                    k2 += numOfPeoplePerGroup;
                }
                else if (numOfPeoplePerGroup >= 41)
                {
                    everest += numOfPeoplePerGroup;
                }

            }

            double musalaPecent = musala * 1.0 / peopleSum * 100;
            double montblancPecent = monblanc * 1.0 / peopleSum * 100;
            double kilimandjaroPecent = kilimandjaro * 1.0 / peopleSum * 100;
            double k2Pecent = k2 * 1.0 / peopleSum * 100;
            double everestPecent = everest * 1.0 / peopleSum * 100;

            Console.WriteLine($"{musalaPecent:f2}%");
            Console.WriteLine($"{montblancPecent:f2}%");
            Console.WriteLine($"{kilimandjaroPecent:f2}%");
            Console.WriteLine($"{k2Pecent:f2}%");
            Console.WriteLine($"{everestPecent:f2}%");

        }
    }
}
