using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala
{
    class Materia
    {
        public string NomeMateria;
        public double Nota1 = 0.00, Nota2 = 0.00, Nota3 = 0.00, Nota4 = 0.00;
        public readonly double NotaMaxima = 10.00;
        public readonly double MediaNecessaria = 6.00;
        public double MediaFinal = 0.00;

        public Materia()
        {

        }
        public Materia(string materia)
        {
            NomeMateria = materia;
        }

        public double calcularMedia(double n1, double n2, double n3, double n4)
        {
            double total = (n1 + n2 + n3 + n4) / 4;
            return total;
        }

        public void AlterarNota(double nota, int bimestre)
        {
            switch (bimestre)
            {
                case 1:
                    Nota1 = nota;
                    break;
                case 2:
                    Nota2 = nota;
                    break;
                case 3:
                    Nota3 = nota;
                    break;
                case 4:
                    Nota4 = nota;
                    break;
            }
        }
        public void exibirMateria(Aluno aluno, SalaDeAula sala)
        {
            Console.Clear();
            Console.WriteLine("Aluno:   {0}", aluno.NomeAluno);
            Console.WriteLine("Matéria: {0}", this.NomeMateria);
            Console.WriteLine();
            Console.WriteLine("----------- ||Notas por bimestre|| ------------");
            Console.WriteLine("1- Primeiro: " + this.Nota1.ToString("F2"));
            Console.WriteLine("2- Segundo:  " + this.Nota2.ToString("F2"));
            Console.WriteLine("3- Terceiro: " + this.Nota3.ToString("F2"));
            Console.WriteLine("4- Quarto:   " + this.Nota4.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Escolha a nota que deseja alterar (digite o código e aperte enter):");
            int notaAlterar = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Agora digite a nova nota: ");

            double novaNota = double.Parse(Console.ReadLine());
            
            //Verifica se a nota é válida
            if(novaNota < 0 || novaNota > NotaMaxima) {
                Console.Clear();
                Console.WriteLine("Nota digitada com valores inválidos! O que deseja fazer a seguir?");
            }
            else
            {
                AlterarNota(novaNota, notaAlterar);
                Console.Clear();
                Console.WriteLine("Nota alterada com sucesso! O que deseja fazer a seguir?");
            }
            Console.WriteLine();
            Console.WriteLine("1 - Visualizar lista de notas");
            Console.WriteLine("2 - Voltar ao menu principal");
            Console.WriteLine();
            Console.WriteLine("Digite o código e aperte enter:");

            int cod = int.Parse(Console.ReadLine());
            switch (cod)
            {
                case 1:
                    aluno.exibirAluno(sala);
                    break;
                case 2:
                    break;
            }
        }
    }
}
