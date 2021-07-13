using System;
using System.Collections.Generic;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            aulas.Add("Conclusão");

            Imprimir(aulas);
        }

        private static void Imprimir(List<string> aulas)
        {
            foreach(string aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
