using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala
{
    class Aluno
    {
        public string nomeAluno;
        int numLista;
        public Materia[] materias = new Materia[5];
        public bool situacaoAluno;

        public Aluno(string nome)
        {
            this.nomeAluno = nome;
            //Declara todas as matérias de aluno.
            materias[0] = new Materia("Portugues");
            materias[1] = new Materia("Matematica");
            materias[2] = new Materia("Historia");
            materias[3] = new Materia("Geografia");
            materias[4] = new Materia("Ciencias");

        }

        public string getNomeAluno()
        {
            return nomeAluno;
        }
        public void setNomeAluno(string nomeAluno)
        {
            this.nomeAluno = nomeAluno;
        }

        public void exibirAluno()
        {
            Console.Clear();
            Console.WriteLine("Nome: {0}", this.getNomeAluno());
            Console.WriteLine();
            Console.WriteLine("Matérias e notas:");
            Console.WriteLine();
            for (int i = 0; i < materias.Length; i++)
            {
                materias[i].mediaFinal = materias[i].calcularMedia(materias[i].nota1, materias[i].nota2, materias[i].nota3, materias[i].nota4);
                Console.WriteLine("{6} - {0}  | {1} | {2} | {3} | {4} | {5}",
                    materias[i].nomeMateria,
                    materias[i].nota1,
                    materias[i].nota2,
                    materias[i].nota3,
                    materias[i].nota4,
                    materias[i].mediaFinal,
                    i + 1);
            }
            Console.WriteLine("Aperte qualquer botao para continuar");
            int button = int.Parse(Console.ReadLine());
        }
    }
}
