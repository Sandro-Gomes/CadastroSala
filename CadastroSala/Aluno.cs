using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala
{
    class Aluno
    {
        public string NomeAluno;
        int numLista;
        public Materia[] materias = new Materia[5];
        public bool situacaoAluno;

        public Aluno(string nome)
        {
            NomeAluno = nome;
            //Declara todas as matérias de aluno.
            materias[0] = new Materia("Portugues");
            materias[1] = new Materia("Matematica");
            materias[2] = new Materia("Historia");
            materias[3] = new Materia("Geografia");
            materias[4] = new Materia("Ciencias");

        }

        public string getNomeAluno()
        {
            return NomeAluno;
        }
        public void setNomeAluno(string nomeAluno)
        {
            NomeAluno = nomeAluno;
        }

        public void exibirAluno(SalaDeAula sala)
        {
            Console.Clear();
            Console.WriteLine("Nome: {0}", this.getNomeAluno());
            Console.WriteLine();
            Console.WriteLine("Matérias e notas:");
            Console.WriteLine();
            Console.WriteLine("Materia\t\t| 1Bim\t| 2Bim\t| 3Bim\t| 4Bim\t| Final");
            Console.WriteLine();
            for (int i = 0; i < materias.Length; i++)
            {
                materias[i].MediaFinal = materias[i].calcularMedia(materias[i].Nota1, materias[i].Nota2, materias[i].Nota3, materias[i].Nota4);
                Console.WriteLine("{6}- {0:F1}\t| {1:F1}\t| {2:F1}\t| {3:F1}\t| {4:F1}\t| {5:F1}",
                    materias[i].NomeMateria,
                    materias[i].Nota1,
                    materias[i].Nota2,
                    materias[i].Nota3,
                    materias[i].Nota4,
                    materias[i].MediaFinal,
                    i+1);
            }
            Console.WriteLine();
            Console.WriteLine("Escolha a matéria que deseja vizualizar:");
            Console.WriteLine();
            Console.WriteLine("Digite o código e aperte enter:");
            int button = int.Parse(Console.ReadLine());
            materias[button-1].exibirMateria(this, sala);
            
        }
    }
}
