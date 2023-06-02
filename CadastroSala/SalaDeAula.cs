using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala
{
    class SalaDeAula
    {
        public List<Aluno> lista = new List<Aluno>();
        public int proxAluno = 0;
        public int numTurma;
        private int serie;

        public SalaDeAula(int numTurma, int serie)
        {
            this.numTurma = numTurma;
            this.serie = serie;
        }

        public void cadastrarNovoAluno()
        {
            Console.WriteLine("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();
            lista.Add(new Aluno(nome));
            Console.Clear();
        }

        public void exibirAlunosCadastrados()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=======||Lista de Alunos||=======");
                Console.WriteLine();
                foreach (Aluno alunos in lista)
                {
                    int index = lista.IndexOf(alunos);
                    Console.WriteLine("{0} - {1}", index + 1, alunos.nomeAluno);
                }
                Console.WriteLine();

                //Seleciona aluno e exibe o conteúdo relacionado ao mesmo.
                /*Console.WriteLine("Digite o número do aluno que deseja visualizar:");
                int j = int.Parse(Console.ReadLine());
                alunos[j - 1].exibirAluno();
                */

                Console.WriteLine("Aperte qualquer botao para continuar");
                int button = int.Parse(Console.ReadLine());
                switch (button)
                {
                    case 1:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int getSerie()
        {
            return serie;
        }
    }
}
