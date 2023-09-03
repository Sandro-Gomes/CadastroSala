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
            lista.Sort();
        }

        public void InserirNovoAluno(Aluno aluno)
        {
            ListaAlunos.Add(aluno);
            this.OrdenarAlunos(ListaAlunos);        }

    }
}
