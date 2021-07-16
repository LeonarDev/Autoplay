using System;

namespace ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoDaVelha();


        }

        private static void JogoDaVelha()
        {
            // JOGO DA VELHA
            // [0,0]  [1,0]   [2,0]
            // [0,1]  [1,1]   [2,1]
            // [0,2]  [1,2]   [2,2]

            char[,] jogo = new char[3, 3];

            jogo[0, 0] = 'X';
            jogo[1, 0] = ' ';
            jogo[2, 0] = 'O';

            jogo[0, 1] = 'X';
            jogo[1, 1] = 'X';
            jogo[2, 1] = 'O';

            jogo[0, 2] = ' ';
            jogo[1, 2] = 'O';
            jogo[2, 2] = 'X';

            for (var y = 0; y < 3; y++)
            {
                for (var x = 0; x < 3; x++)
                {
                    Console.Write(jogo[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
