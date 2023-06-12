using System;
using System.Collections.Generic;
using System.Text;


namespace CadastroSala
{
    internal class Controller
    {
        public void MenuTurma(SalaDeAula sala)
        {
            bool executar = true;
            int i;
            while (executar == true)
            {
                Console.Clear();
                Console.WriteLine("Turma {0} | {1}ª Série", sala.NumTurma, sala.Serie);
                Console.WriteLine();
                Console.WriteLine("[1] Cadastrar Novo Aluno");
                Console.WriteLine("[2] Alunos Cadastrados");
                Console.WriteLine("[3] Notas da turma");
                Console.WriteLine("[4] Sair");
                Console.WriteLine();
                Console.WriteLine("Digite a opção desejada:");
                try
                {
                    i = int.Parse(Console.ReadLine());

                    switch (i)
                    {
                        case 1:
                            Console.Clear();
                            sala.cadastrarNovoAluno();
                            break;
                        case 2:
                            Console.Clear();
                            sala.exibirAlunosCadastrados();
                            break;
                        case 3:
                            //Opção 3: Finaliza programa
                            Console.Clear();
                            executar = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida, tente novamente");
                            break;
                    }
                }
                catch (Exception e)
                {
                }

            }
        }
    }
}
