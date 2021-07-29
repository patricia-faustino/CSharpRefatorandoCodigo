using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatorando2
{

    partial class Programa
    {
        void Testar()
        {
            Aluno aluno = new Aluno();
            aluno.Adicionar(new Curso("JavaScript Básico"));
            aluno.Adicionar(new Curso("C# Intermediário"));
            aluno.Adicionar(new Curso("Java Avançado"));
        }
    }

    class Aluno
    {
        private readonly List<Curso> cursos;
        public IReadOnlyCollection<Curso> Cursos { get { return new ReadOnlyCollection<Curso>(cursos); } }

        public Aluno()
        {
            cursos = new List<Curso>();
        }

        internal void Adicionar(Curso curso)
        {
            cursos.Add(curso);
        }

        internal void Remover(Curso curso)
        {
            cursos.Remove(curso);
        }
    }

    class Curso
    {
        readonly string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public Curso(string nome)
        {
            this.nome = nome;
        }
    }
}
