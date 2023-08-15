using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala.Entities
{
    class Aluno
    {
        public string Nome { get; set; }
        public List<Materia> Materias { get; set; } = new List<Materia>();
        int idAluno { get; set; }
        public bool SituacaoAluno { get; set; }
        public Serie Serie { get; set; }

        public Aluno()
        {
            Materias.Add(new Materia("Portugues", 1));
            Materias.Add(new Materia("Matematica", 2));
            Materias.Add(new Materia("Historia", 3));
            Materias.Add(new Materia("Geografia", 4));
            Materias.Add(new Materia("Ciencias", 5));
        }

        public Aluno(string nomeAluno)
        {
            Nome = nomeAluno;
            Materias.Add(new Materia("Portugues", 1));
            Materias.Add(new Materia("Matematica", 2));
            Materias.Add(new Materia("Historia", 3));
            Materias.Add(new Materia("Geografia", 4));
            Materias.Add(new Materia("Ciencias", 5));
        }

        public Aluno(string nomeAluno, Serie serie)
        {
            Nome = nomeAluno;
            Serie = serie;
            Materias.Add(new Materia("Portugues", 1));
            Materias.Add(new Materia("Matematica", 2));
            Materias.Add(new Materia("Historia", 3));
            Materias.Add(new Materia("Geografia", 4));
            Materias.Add(new Materia("Ciencias", 5));
        }

        public void exibirAluno(SalaDeAula sala)
        {

        }
    }
}
