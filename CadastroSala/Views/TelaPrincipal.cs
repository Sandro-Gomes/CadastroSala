using CadastroSala.Entities;
using CadastroSala.Entities.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CadastroSala.Views
{

    internal static class TelaPrincipal
    {

        public static int Exibir(SalaDeAula sala)
        {
            Console.Clear();
            Console.WriteLine("Aplicação de cadastro de notas");
            Console.WriteLine();
            Console.WriteLine("Turma {0} | 6ª Série", sala.NumTurma);
            Console.WriteLine();
            Console.WriteLine("[1] Cadastrar Novo Aluno");
            Console.WriteLine("[2] Alunos Cadastrados");
            Console.WriteLine("[3] Sair");
            Console.WriteLine();
            Console.Write("Digite a opção desejada:");
            return int.Parse(Console.ReadLine());
        }

        public static Aluno TelaCadastrarAluno()
        {
            Console.Clear();
            Console.Write("Digite o nome do aluno: ");
            Aluno aluno = new Aluno(Console.ReadLine());
            Console.WriteLine("Aluno " + aluno.Nome + " cadastrado com sucesso!");
            Console.ReadLine();
            return aluno;

        }
        public static void TelaAlunosCadastrados(List<Aluno> alunos)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=======||Lista de Alunos||=======");
                Console.WriteLine();
                foreach (Aluno x in alunos)
                {
                    int index = alunos.IndexOf(x);
                    Console.WriteLine("{0} - {1}", index + 1, x.Nome);
                }
                Console.WriteLine();

                Console.WriteLine("Digite o número do aluno que deseja visualizar:");
                int j = int.Parse(Console.ReadLine());
                ExibirAluno(alunos[j - 1]);

                Console.WriteLine("Aperte qualquer botao para continuar");
                int button = int.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ExibirAluno(Aluno aluno)
        {
            bool rodando = true;
            while (rodando)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Nome: {0}", aluno.Nome);
                    Console.WriteLine();
                    Console.WriteLine("Matérias e notas:");
                    Console.WriteLine();
                    Console.WriteLine("Materia\t\t| 1Bim\t| 2Bim\t| 3Bim\t| 4Bim\t| Final");
                    Console.WriteLine();

                    foreach (Materia x in aluno.Materias)
                    {
                        Console.WriteLine("{6}- {0:F1}\t| {1:F1}\t| {2:F1}\t| {3:F1}\t| {4:F1}\t| {5:F1}",
                            x.NomeMateria,
                            x.NotaBimestre[0],
                            x.NotaBimestre[1],
                            x.NotaBimestre[2],
                            x.NotaBimestre[3],
                            x.MediaFinal,
                            x.IdMateria);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Escolha a matéria que deseja vizualizar!");
                    Console.WriteLine();
                    Console.Write("Digite o código e aperte enter:");
                    int button = int.Parse(Console.ReadLine());
                    Materia materiaSelecionada;
                    foreach (Materia x in aluno.Materias)
                    {
                        if (x.IdMateria == button)
                        {
                            materiaSelecionada = x;
                            ExibirMateria(materiaSelecionada, aluno);
                        }
                    }
                }
                catch (DomainException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
        }
        public static void ExibirMateria(Materia materia, Aluno aluno)
        {
            bool rodando = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Matéria: " + materia.NomeMateria);
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine();
                Console.WriteLine("Notas(Bimestre):");
                Console.WriteLine();
                Console.WriteLine("1 - Primeiro : " + materia.NotaBimestre[0]);
                Console.WriteLine("2 - Segundo  : " + materia.NotaBimestre[1]);
                Console.WriteLine("3 - Terceiro : " + materia.NotaBimestre[2]);
                Console.WriteLine("4 - Quarto   : " + materia.NotaBimestre[3]);
                Console.WriteLine();
                Console.Write("Deseja alterar alguma matéria? (S/N): ");
                char c = char.Parse(Console.ReadLine());
                if (c == 'S' || c == 's')
                {
                    Console.Write("Digite o código do semestre que deseja alterar: ");
                    int i = int.Parse(Console.ReadLine());
                    if (i >= materia.NotaBimestre.Length || i < 0)
                        throw new DomainException("Bimestre inválido");
                    Console.Write("Digite o novo valor: ");
                    double d = double.Parse(Console.ReadLine());
                    materia.AlterarNota(d, i);
                }
                else
                {
                    rodando = false;
                }
            } while (rodando);

        }
    }
}

