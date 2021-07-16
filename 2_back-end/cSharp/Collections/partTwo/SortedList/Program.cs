using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            Imprimir(alunos);

            alunos.Remove("AL");

            alunos.Add("MO", new Aluno("Marcelo", 12345));

            Imprimir(alunos);
            
            //apresentando nova coleção: SortedList
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Imprimir(sorted);
        }

        private static void Imprimir(IDictionary<string, Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();
        }
    }
}
