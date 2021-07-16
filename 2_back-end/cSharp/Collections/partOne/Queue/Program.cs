using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            Enfileirar("Corsa");
            Enfileirar("Gol Mil");
            Enfileirar("Parati");
            Enfileirar("Brasilia");
            Enfileirar("Fiat 147");
            Enfileirar("Del Rey");
            Enfileirar("Kadett");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
        }

        private static void Enfileirar(string veiculoEntrando)
        {
            Console.WriteLine();
            Console.WriteLine($"{veiculoEntrando} ENTROU na fila.");
            pedagio.Enqueue($"{veiculoEntrando}");
            ImprimirFila();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "Parati")
                {
                    Console.WriteLine($"Parati está fazendo o pagamento");
                }
            }
            string veiculoSaindo = pedagio.Dequeue();
            Console.WriteLine();
            Console.WriteLine($"{veiculoSaindo} SAIU da fila.");
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine();
            Console.WriteLine("FILA: ");
            foreach (var veiculo in pedagio)
            {
                Console.WriteLine($"- {veiculo}");
            }
        }
    }
}
