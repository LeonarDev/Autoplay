using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeObjetos
{
    class Curso
    {
        private IList<Aula> aulas;
        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        internal bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //LINQ = Language Integrated Query
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"CURSO: {nome}, TEMPO: {TempoTotal} minutos,\nAULAS: {string.Join(", ", aulas)}.";
        }
    }
}
