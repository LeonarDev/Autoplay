using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900 && salario <= 2800)
            {
                Console.WriteLine("IR de 7.5%: Pode deduzir até R$ 142");
            }
            else if (salario >= 2800.01 && salario <= 3751)
            {
                Console.WriteLine("IR de 15%: Pode deduzir até R$ 350");
            }
            else if (salario >= 3751.01 && salario <= 4664)
            {
                Console.WriteLine("IR de 22.5%: Pode deduzir até R$ 636");
            }
        }
    }
}
