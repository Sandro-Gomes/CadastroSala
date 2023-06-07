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
            Controller controller = new Controller();
            while(executar == true){
                controller.menuInicial(sala1);
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
                            sala1.exibirAlunosCadastrados(controller);
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
