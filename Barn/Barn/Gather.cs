using System;

namespace Barn
{
    class Chicken
    {
        public string Name { get; set; }

        public Chicken(string name)
        { Name = name; }

        public int gather()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2);
        }
    }

    class Cow
    {
        public string Name { get; set; }

        public Cow(string name)
        { Name = name; }

        public int gather()
        {
            Random rnd = new Random();
            return rnd.Next(8, 13);
        }
    }

    class Gather
    {
        private string[] dictionary = new string[30] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"}; 
        private int ChickenCount;
        private int CowCount;

        public Gather(int Chickens, int Cows)
        {
            ChickenCount = Chickens;
            CowCount = Cows;
        }

        public void get()
        {
            int ChickenOutCome=0;
            int CowsOutCome=0;
            string CowsNames = "";
            string ChicknNames = "";

            Cow[] cows = new Cow[CowCount];
            for (int i = 0; i < CowCount; i++)
            {
                cows[i] =new Cow( dictionary[i]);
                CowsOutCome += cows[i].gather();
                if (i == 0)
                    CowsNames += cows[i].Name;
                else
                    CowsNames += ", " + cows[i].Name;
            }

            Chicken[] chickens = new Chicken[ChickenCount];
            for (int i = 0; i < ChickenCount; i++)
            {
                chickens[i] = new Chicken(dictionary[i+10]);
                ChickenOutCome += chickens[i].gather();
                if(i==0)
                    ChicknNames += chickens[i].Name;
                else
                    ChicknNames +=", " +chickens[i].Name;
            }

            Console.WriteLine("Cows outcome="+ CowsOutCome+ "\r\nCows names:\r\n"+CowsNames+ "\r\n\r\nChickens outcome=" + ChickenOutCome+ "\r\n"+ "Chickens names:\r\n"+ ChicknNames);
        }
    }
}
