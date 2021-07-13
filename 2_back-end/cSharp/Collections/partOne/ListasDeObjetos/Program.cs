using System;
using System.Collections.Generic;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 30);
            var aulaDotNet = new Aula("Lidando com .NET", 45);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 18);
            var aulaConclusão = new Aula("Conclusão", 25);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaDotNet);
            aulas.Add(aulaSets);
            aulas.Add(aulaConclusão);

            Imprimir(aulas);

            aulas.Sort();
            Console.WriteLine("Ordenando pelo título (implementando a interface IComparable para conseguir acessar o método CompareTo):");
            Imprimir(aulas);

            aulas.Sort((elemento1, elemento2) => elemento1.Tempo.CompareTo(elemento2.Tempo));
            Console.WriteLine("Ordenando pelo tempo (overload 2 do método Sort):");
            Imprimir(aulas);

        }

        private static void Imprimir(List<Aula> aulas)
        {
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }
                Console.WriteLine("");
        }

        class Aula : IComparable
        {
            private string titulo;
            private int tempo;

            public Aula(string titulo, int tempo)
            {
                this.titulo = titulo;
                this.tempo = tempo;
            }

            public string Titulo { get => titulo; set => titulo = value; }
            public int Tempo { get => tempo; set => tempo = value; }

            public int CompareTo(object obj)
            {
                Aula that = obj as Aula;
                return this.titulo.CompareTo(that.titulo);
            }

            public override string ToString()
            {
                return $"[TÍTULO: {titulo} | TEMPO: {tempo} minutos]";
            }
        }
    }
}
