using System;
using System.Collections.Generic;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaLista();
            TestaListaDeObjetos();
            TestaSets();

            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado? {csharpColecoes.EstaMatriculado(a1)}");

            Console.WriteLine();
            Aluno a1Copy = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine("a1Copy: Vanessa Tonini está matriculada? " + csharpColecoes.EstaMatriculado(a1Copy));

            Console.WriteLine();
            Console.WriteLine($"a1 é equals a Tonini? {a1.Equals(a1Copy)}");

            Console.WriteLine();
        }

        private static void TestaSets()
        {
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine($"Lista de alunos: {string.Join(", ", alunos)}");
            Console.WriteLine();

            Console.WriteLine("Remove 'Ana Losnak'");
            alunos.Remove("Ana Losnak");
            Console.WriteLine($"Lista de alunos: {string.Join(", ", alunos)}");
            Console.WriteLine(
                );
            Console.WriteLine("Adiciona 'Marcelo Oliveira'");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine($"Lista de alunos: {string.Join(", ", alunos)}");

            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine($"Lista de alunos: {string.Join(", ", alunos)}");

            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine($"Lista de alunos: {string.Join(", ", alunosEmLista)}");
        }

        private static void TestaListaDeObjetos()
        {
            Curso csharpColecoes = new Curso("C# Collections", "Leonardo Majevski");
            csharpColecoes.Adiciona(new Aula("xablau", 12));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 30));
            csharpColecoes.Adiciona(new Aula("Modelando a com Coleções", 19));
            Console.WriteLine("------ Utilizando o método 'Adiciona()' ------");
            Imprimir(csharpColecoes.Aulas);

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            aulasCopiadas.Sort();
            Console.WriteLine("------ Copiando a interface da lista<Curso> (somente leitura) para conseguir utilizar o método 'Sort()' ------");
            Imprimir(aulasCopiadas);

            Console.WriteLine("------ Totalizando o tempo total do Curso ------");
            Console.WriteLine($"Tempo total do curso: {csharpColecoes.TempoTotal} minutos.");

            Console.WriteLine(csharpColecoes);
        }

        private static void TestaLista()
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
            Console.WriteLine("------ Ordenando pelo título (implementando a interface IComparable para conseguir acessar o método CompareTo): ------");
            Imprimir(aulas);

            aulas.Sort((elemento1, elemento2) => elemento1.Tempo.CompareTo(elemento2.Tempo));
            Console.WriteLine("------ Ordenando pelo tempo (overload 2 do método Sort): ------");
            Imprimir(aulas);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }
                Console.WriteLine("");
        }
    }
}
