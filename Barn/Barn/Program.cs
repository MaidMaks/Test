﻿using System;

namespace Barn
{
    class Program
    {

        static void Main(string[] args)
        {

            Chicken chicken = new Chicken("Chiken", 1, 0);
            Cow cow = new Cow("Cow", 12, 8);
            Gath gath = new Gath();


            Console.WriteLine("Chickens outcome=" + gath.Gather(chicken, 20));
            Console.WriteLine("Cows outcome=" + gath.Gather(cow, 10));
            Console.ReadKey();
        }
    }
}
