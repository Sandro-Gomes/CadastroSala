using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala.Entities
{
    class SalaDeAula
    {
        public List<Aluno> ListaAlunos = new List<Aluno>();
        public int IdSala { get; set; }
        public int NumTurma { get; set; }
        private int Serie { get; set; }

        public SalaDeAula(int numTurma, int serie)
        {
            this.NumTurma = numTurma;
            this.Serie = serie;
        }

        public void OrdenarAlunos(List<Aluno> lista)
        {
            lista.Sort((obj1, obj2) => obj1.Nome.CompareTo(obj2.Nome));
        }

        public void InserirNovoAluno(Aluno aluno)
        {
            ListaAlunos.Add(aluno);           
        }

    }
}
