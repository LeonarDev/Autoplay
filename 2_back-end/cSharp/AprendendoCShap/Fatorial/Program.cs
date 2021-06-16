using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int resultado = 1;

            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
                Console.WriteLine("O fatorial de " + n + " é " + resultado);
        }
    }
}

// fatorial de n
// n! =  n  * (n-1) * (n-2) …  1
// 4! =  4  *  4-1  *  4-2  * 4-1 
// 4! =  4  *   3   *   2   *  1
// 4! =  24