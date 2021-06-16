using System;

namespace MultiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cont = 1; cont < 100; cont++)
            {
                if (cont % 3 == 0)
                {
                    Console.WriteLine(cont);
                }
            }
        }
    }
}
