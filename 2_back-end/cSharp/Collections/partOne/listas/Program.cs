using System;
using System.Collections.Generic;
using System.Linq;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "- Introdução às Coleções";
            string aulaModelando = "- Modelando a Classe Aula";
            string aulaSets = "- Trabalhando com Conjuntos";

            //List<string> aulas = new List<string>();
            //aulas.Add(aulaIntro);
            //aulas.Add(aulaModelando);
            //aulas.Add(aulaSets);
            //aulas.Add("Conclusão");

            List<string> aulas = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            Imprimir(aulas);

            Console.WriteLine($"A primeira aula é '{aulas.First()}'");
            Console.WriteLine($"A última aula é '{aulas.Last()}'");
            Console.WriteLine();

            Console.WriteLine($"A primeira referêcia que contém a palavra 'Trabalhando' é: '{aulas.First(aula => aula.Contains("Trabalhando"))}'");
            Console.WriteLine();

            Console.WriteLine($"A última referêcia que contém a palavra 'Trabalhando' é: '{aulas.Last(aula => aula.Contains("Trabalhando"))}'");
            Console.WriteLine();

            // Devolve o valor default (em objeto ou string = null | em int = 0 | etc...) quando não encontra ocorrências:
            //      aulas.firstOrDefault(aula => aula.Contains("Qualquer coisa"));

            Console.WriteLine("Invertendo a ordem de uma lista:");
            aulas.Reverse();
            Imprimir(aulas);

            aulas.Reverse();
            Imprimir(aulas);

            Console.WriteLine("Removendo um elemento (o último) da lista:");
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            Console.WriteLine("Reatribuindo a lista (aulas2):");
            List<string> aulas2 = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
            Imprimir(aulas2);

            Console.WriteLine("Removendo uma faixa de elementos (os 2 últimos) da lista:");
            aulas2.RemoveRange(aulas2.Count - 2, 2);
            Imprimir(aulas2);
            //O método acima remove uma faixa (range) que começa no penúltimo elemento (aulas.Count - 2) e abrange 2 elementos.

            Console.WriteLine("Declarando nova lista (aulas3):");
            List<string> aulas3 = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets,
                "- Conclusão de cursos mod1",
                "- Conclusão de módulo"
            };
            Imprimir(aulas3);

            Console.WriteLine("Ordenando aulas: ");
            aulas3.Sort();
            Imprimir(aulas3);

            Console.WriteLine("Ordenando aulas por tamanho de string:");
            aulas3.Sort((a, b) => a.Length.CompareTo(b.Length));
            Imprimir(aulas3);

            Console.WriteLine("Removendo elementos pelo seu conteúdo ('Conclusão'):");
            var conteudo = "Conclusão";
            aulas3.RemoveAll(aula => aula.Contains(conteudo));
            Imprimir(aulas3);

            Console.WriteLine("Copiando uma lista a partir de uma faixa de elementos e gerando uma nova:");
            List<string> copia = aulas3.GetRange(aulas3.Count - 2, 2);
            Imprimir(copia);

            Console.WriteLine("Clonando uma lista criando uma nova instância de List<T>:");
            List<string> clone = new List<string>(aulas3);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            foreach(string aula in aulas)
            {
                Console.WriteLine(aula);
            }
                Console.WriteLine();
        }

        //private static void Imprimir(List<string> aulas)
        //{
        //    for (int i = 0; i < aulas.Count; i++)
        //    {
        //        Console.WriteLine(aulas[i]);
        //    }
        //    Console.WriteLine();
        //}

        //private static void Imprimir(List<string> aulas)
        //{
        //    aulas.ForEach(aula => Console.WriteLine(aula));
        //    Console.WriteLine();
        //}
    }
}
