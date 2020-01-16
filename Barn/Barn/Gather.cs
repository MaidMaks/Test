using System;

namespace Barn
{
    class Animal
    {
        public string Name { get; }
        public int mx { get; }
        public int mn { get; }
        private Random rnd = new Random();
        public Animal(string name, int max, int min)
        { Name = name; mx = max;mn = min; }

        public int Gather()
        {
            return rnd.Next(mn, mx+1);
        }
    }

    sealed class Chicken:Animal
    {
        public Chicken(string name, int max, int min) :base(name,max,min)
        {  }
    }

    sealed class Cow:Animal
    {
        public Cow(string name, int max, int min) : base(name, max, min)
        { }
    }

    class Gath
    {
        public int Gather(Animal animal, int ammount)
        {
            int outc= 0;
            for (int i = 0; i < ammount; i++)
                outc += animal.Gather();
            return outc;
        }

    }
}