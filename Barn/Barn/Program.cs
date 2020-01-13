using System;

namespace Barn
{
    class Program
    {
        static int Cows;
        static int Chikns;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter Number of сows");
                Cows = Convert.ToInt32(Console.ReadLine());
            } while (Cows > 10);

            do
            {
                Console.WriteLine("Enter Number of chickens");
                Chikns = Convert.ToInt32(Console.ReadLine());
            }
            while (Chikns > 20);
            Gather gather = new Gather(Chikns, Cows);
            gather.get();
            Console.ReadKey();

        }
    }
}
