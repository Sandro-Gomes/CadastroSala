using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala
{
    class SalaDeAula
    {
        private List<Aluno> _lista = new List<Aluno>();
        private int _proxAluno = 0; //Não lembro onde está sendo usado

        public int NumTurma { get; private set; }
        public int Serie { get; private set; }

        public SalaDeAula(int numTurma, int serie)
        {
            NumTurma = numTurma;
            Serie = serie;
        }

        public void cadastrarNovoAluno()
        {
            Console.WriteLine("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();
            _lista.Add(new Aluno(nome));
            Console.Clear();
            _lista.Sort((obj1, obj2) => obj1.NomeAluno.CompareTo(obj2.NomeAluno));
        }

        public void exibirAlunosCadastrados()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=======||Lista de Alunos||=======");
                Console.WriteLine();
                foreach (Aluno alunos in _lista)
                {
                    int index = _lista.IndexOf(alunos);
                    Console.WriteLine("{0} - {1}", index + 1, alunos.NomeAluno);
                }
                Console.WriteLine();

                //Seleciona aluno e exibe o conteúdo relacionado ao mesmo.
                Console.WriteLine("Digite o número do aluno que deseja visualizar:");
                int j = int.Parse(Console.ReadLine());
                _lista[j - 1].exibirAluno(this);

                Console.WriteLine("Aperte qualquer botao para continuar");
                int button = int.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
