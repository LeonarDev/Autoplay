using System;
using System.Linq;

namespace OperacoesConjuntosLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequencia1 = { "janeiro", "fevereiro", "março" };
            string[] sequencia2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine($"Sequência 1: {string.Join(", ", sequencia1)}");
            Console.WriteLine($"Sequência 2: {string.Join(", ", sequencia2)}");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("CONCATENAÇÃO DE DUAS SEQUÊNCIAS:");
            int contadorConcat = 1;
            var consulta = sequencia1.Concat(sequencia2);
            foreach (var item in consulta)
            {
                Console.WriteLine($"{contadorConcat}) {item}");
                contadorConcat++;
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("UNIÃO DE DUAS SEQUÊNCIAS:");
            int contadorUnion = 1;
            var consulta2 = sequencia1.Union(sequencia2);
            foreach (var item in consulta2)
            {
                Console.WriteLine($"{contadorUnion}) {item}");
                contadorUnion++;
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("UNIÃO DE DUAS SEQUÊNCIAS IGNORANDO CASE:");
            int contadorUnionIgnoreCase = 1;
            var consulta3 = sequencia1.Union(sequencia2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine($"{contadorUnionIgnoreCase}) {item}");
                contadorUnionIgnoreCase++;
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("INTERSECÇÃO DE DUAS SEQUÊNCIAS:");
            int contadorInterseccao = 1;
            var consulta4 = sequencia1.Intersect(sequencia2);
            foreach (var item in consulta4)
            {
                Console.WriteLine($"{contadorInterseccao}) {item}");
                contadorInterseccao++;
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("LINDANDO COM EXCEPT: ELEMENTOS DA SEQUÊNCIA 1 QUE NÃO ESTÃO NA SEQUÊNCIA 2:");
            int contadorExcept = 1;
            var consulta5 = sequencia1.Except(sequencia2);
            foreach (var item in consulta5)
            {
                Console.WriteLine($"{contadorExcept}) {item}");
                contadorExcept++;
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("LINDANDO COM EXCEPT: ELEMENTOS DA SEQUÊNCIA 2 QUE NÃO ESTÃO NA SEQUÊNCIA 1:");
            int contadorExcept2 = 1;
            var consulta6 = sequencia2.Except(sequencia1);
            foreach (var item in consulta6)
            {
                Console.WriteLine($"{contadorExcept2}) {item}");
                contadorExcept2++;
            }
        }
    }
}
