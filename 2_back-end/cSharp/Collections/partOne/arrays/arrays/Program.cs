using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaSets = "Trabalhando com Conjuntos";
            string aulaModelando = "Modelando a Classe Aula";

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaSets,
                aulaModelando
            };

            Imprimir(aulas);
            Array.Reverse(aulas);
            Imprimir(aulas);
            Array.Sort(aulas);
            Imprimir(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, copia, 2);
            Imprimir(copia);

            string[] copia2 = new string[2];
            Array.Copy(aulas, 1, copia2, 0, 2);
            Imprimir(copia2);

            string[] clone = aulas.Clone() as string[];
            Console.WriteLine("Clone: "); ;
            Imprimir(clone);

            Array.Clear(clone, 1, 2);
            Imprimir(clone);
        }

        private static void Imprimir(string[] aulas)
        {
            int index = 0;
            foreach (string aula in aulas)
            {
                Console.WriteLine($"Index {index}: {aula}");
                index++;
            }
            Console.WriteLine("");

        }
    }
}
