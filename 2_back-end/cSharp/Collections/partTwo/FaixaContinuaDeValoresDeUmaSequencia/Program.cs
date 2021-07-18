using System;
using System.Linq;

namespace FaixaContinuaDeValoresDeUmaSequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uma loja de fast-food tem um faturamento que varia dia a dia.
            // Na última semana, essa loja registrou os seguintes faturamentos:
            var dias = new[] {
            new { nome = "segunda", faturamento = 1000 },
            new { nome = "terça", faturamento = 2000 },
            new { nome = "quarta", faturamento = 12500 },
            new { nome = "quinta", faturamento = 11000 },
            new { nome = "sexta", faturamento = 22000 },
            new { nome = "sábado", faturamento = 9000 },
            new { nome = "domingo", faturamento = 18000 }};

            // Essa loja quer saber:
            // quais dias consecutivos tiveram faturamento igual ou superior a 10 mil reais?

            var query = dias
                .SkipWhile(dia => dia.faturamento < 10000)
                .TakeWhile(dia => dia.faturamento >= 10000);

            Console.WriteLine(string.Join(", \n", query));
        }
    }
}
