using System;
using System.Globalization;

namespace TrabalhandoComDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2021,7,16);
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("d"));
            Console.WriteLine(data.ToString("d", new CultureInfo("en-us")));
            Console.WriteLine(data.ToString("dd/MM")); //"MM" (maiúsculo) faz referencia ao mês
            Console.WriteLine(data.ToString("dd/mm")); //"mm" (minusculo) faz referencia ao minuto
            Console.WriteLine(data.ToString("dd/mm/yy"));
            Console.WriteLine();

            data = new DateTime(2021,7,16, 15,43,20);
            Console.WriteLine(data.ToString("hh:mm")); // 03:43
            Console.WriteLine(data.ToString("HH:mm")); // 15:43
            Console.WriteLine(data.ToString("HH:mm:ss.fff")); // 15:43:20.000
            Console.WriteLine();

            Console.WriteLine(data.ToString("D")); // sexta-feira, 16 de julho de 2021
            Console.WriteLine(data.ToString("m")); // 16 de julho
            Console.WriteLine(data.ToString("Y")); // julho de 2021
            Console.WriteLine(data.ToString("G")); // 16/07/2021 15:43:20
            Console.WriteLine(data.ToString("g")); // 16/07/2021 15:43
            Console.WriteLine(data.ToString("T")); // 15:43:20
            Console.WriteLine(data.ToString("t")); // 15:43
            Console.WriteLine(); 

            Console.WriteLine(data.ToString("O")); // O formato de data "viagem de ida-e-volta" gera um formato de string universal (exemplo: 2008-06-12T18:45:15.0000000-05:00) que pode ser convertido de volta para a data e hora originais, sem perda de dados.
            Console.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));
        }
    }
}
