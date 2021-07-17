using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] familias = new string[3][];

            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            int contador = 1;

            foreach(var familia in familias)
            {
                Console.WriteLine($"Família {contador} : { string.Join(", ", familia)}");
                contador++;
            }
        }
    }
}
