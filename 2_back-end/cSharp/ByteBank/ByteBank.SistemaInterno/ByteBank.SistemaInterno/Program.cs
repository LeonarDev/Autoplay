using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(342, 327323);
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
