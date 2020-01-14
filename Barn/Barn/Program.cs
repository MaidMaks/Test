using System;

namespace Barn
{
    class Program
    {

        static void Main(string[] args)
        {
            Gather gather = new Gather(20, 10);
            gather.get();
            Console.ReadKey();

        }
    }
}
