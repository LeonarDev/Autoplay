using System;

namespace ByteBank
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.totalDeContas);

            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine(ContaCorrente.totalDeContas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente outraConta = new ContaCorrente(867, 86745820);
            Console.WriteLine(ContaCorrente.totalDeContas);
        }
    }
}
