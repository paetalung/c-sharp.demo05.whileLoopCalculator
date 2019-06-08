using System;

namespace demo05.whileLoopCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0;
            double total = 0.0;

            Console.WriteLine("How many rounds");
            int round = int.Parse(Console.ReadLine());  // convert str 2 int

            while (add < round)
            {
                add++;
                Console.Write("Please enter your "+add+" value : ");
                double summa = double.Parse(Console.ReadLine());
                total = total + summa;
            }
            Console.WriteLine("Your answer is : "+total+".");

        }

    }
}
