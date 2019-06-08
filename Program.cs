using System;

namespace demo05.whileLoopCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0;
            int total = 0;

            Console.WriteLine("How many rounds");
            string get_round = Console.ReadLine();
            int round = int.Parse(get_round);  // convert str 2 int

            while (add < round)
            {
                add++;
                Console.WriteLine("Please enter your "+add+" value :");
                string get_sum = Console.ReadLine();
                int summa = int.Parse(get_sum);
                total = total + summa;
            }
            Console.WriteLine("Your answer is : "+total+".");

        }

    }
}
