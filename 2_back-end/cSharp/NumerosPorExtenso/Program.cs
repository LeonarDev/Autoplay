using Caelum.Stella.CSharp.Inwords;
using Caelum.Stella.CSharp.Vault;
using System;
using System.Diagnostics;
using System.Globalization;

namespace NumerosPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string extenso = new Numero(valor).Extenso(); // OUTPUT: setenta e cinco
            Console.WriteLine(extenso);
            Console.WriteLine();

            valor = 1534894;
            extenso = new Numero(valor).Extenso(); // OUTPUT: um milhao, quinhentos e trinta e quatro mil oitocentos e noventa e quatro
            Console.WriteLine(extenso);
            Console.WriteLine();

            valor = 1534894.89;
            string extensoBRL = new MoedaBRL(valor).Extenso();
            Console.WriteLine(extensoBRL);
            Console.WriteLine();

            Money money = 10.00;
            Console.WriteLine(money);
            Console.WriteLine();

            double valor1 = 10.00;
            double valor2 = 20.00;
            Money total = valor1 + valor2;
            Console.WriteLine(total);
            Console.WriteLine();

            Money euro = new Money(Currency.EUR, 1000);
            Console.WriteLine(euro);
            Console.WriteLine();

            Money dolar = new Money(Currency.USD, 1000);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine(dolar);

        }
    }
}
