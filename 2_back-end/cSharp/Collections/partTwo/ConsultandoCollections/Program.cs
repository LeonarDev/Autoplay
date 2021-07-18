using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultandoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>
            {
               new Mes("Janeiro", 31),
               new Mes("Fevereiro", 28),
               new Mes("Março", 31),
               new Mes("Abril", 30),
               new Mes("Maio", 31),
               new Mes("Junho", 30),
               new Mes("Julho", 31),
               new Mes("Agosto", 31),
               new Mes("Setembro", 30),
               new Mes("Outubro", 31),
               new Mes("Novembro", 30),
               new Mes("Dezembro", 31)
            };

            //foreach(var mes in meses)
            //{
            //    Console.WriteLine(mes);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Meses com 31 dias, em letras maiúscula, ordenados alfabeticamente:");
            //meses.Sort();
            //foreach(var mes in meses)
            //{
            //    if (mes.Dias == 31)
            //    {
            //        Console.WriteLine($"- {mes.Nome.ToUpper()}");
            //    }
            //}

            IEnumerable<Mes> consulta = meses
                .Where(mes => mes.Dias == 31)
                .OrderBy(mes => mes.Nome);

            Console.WriteLine("Meses com 31 dias:");
            foreach (var item in consulta)
            {
                Console.WriteLine($"- {item.Nome.ToUpper()}");
            }
            Console.WriteLine();

            Console.WriteLine("Consultando os meses do primeiro trimestre do ano:");
            var consultaPrimeiroTrimestre = meses.Take(3);
            foreach (var item in consultaPrimeiroTrimestre)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Consultando os meses seguintes ao primeiro trimestre do ano:");
            var consultaPularTrimestre = meses.Skip(3);
            foreach (var item in consultaPularTrimestre)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Consultando os meses do segundo trimestre do ano:");
            var consultaSegundoTrimestre = meses.Skip(3).Take(3);
            foreach (var item in consultaSegundoTrimestre)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Consultando meses antes que algum comece com a letra 'S':");
            var consultaMesesAntesDeIniciarComS= meses.TakeWhile(mes => !mes.Nome.StartsWith("S"));
            foreach (var item in consultaMesesAntesDeIniciarComS)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Consultando meses a partir daquele que começa com a letra 'S':");
            var consultaMesApartirDoS = meses.SkipWhile(mes => !mes.Nome.StartsWith("S"));
            foreach (var item in consultaMesApartirDoS)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Mes //: IComparable
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        //public int CompareTo(object obj)
        //{
        //    Mes outro = obj as Mes;

        //    return this.Nome.CompareTo(outro.Nome);
        //}

        public override string ToString()
        {
            return $"- {Nome} ({Dias} dias)";
        }
    }
}
