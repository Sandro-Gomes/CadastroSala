using System;

namespace CadastroSala
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaDeAula sala1 = new SalaDeAula(42, 6);
            bool executar = true;
            int i;
            while(executar == true){
                Console.Clear();
                Console.WriteLine("Turma {0} | {1}ª Serie", sala1.numTurma, sala1.getSerie());
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
                            sala1.cadastrarNovoAluno();
                            break;
                        case 2:
                            Console.Clear();
                            sala1.exibirAlunosCadastrados();
                            break;
                        case 3:
                            Console.Clear();
                            //exibirNotasTurma();
                            break;
                        case 4:
                            Console.Clear();
                            executar = false;
                            //exibirNotasTurma();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida, tente novamente");
                            break;
                    }
                }
                catch(Exception e)
                {
                }
                
            }
        }
    }
}
