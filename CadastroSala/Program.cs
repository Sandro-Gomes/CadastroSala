using System;
using System.Collections.Generic;
using CadastroSala.Entities;
using CadastroSala.Entities.Exceptions;
using CadastroSala.Views;

namespace CadastroSala
{
    class Program
    {

        static void Main(string[] args)
        {
            SalaDeAula sala = new SalaDeAula(42,6);
            bool executar = true;
            int i;
            while (executar == true)
            {
                try
                {
                    i = TelaPrincipal.Exibir(sala);

                    if(i == 1)
                    {
                        sala.InserirNovoAluno(TelaPrincipal.TelaCadastrarAluno());
                    }
                    else if (i == 2)
                    {
                        TelaPrincipal.TelaAlunosCadastrados(sala.ListaAlunos);
                    }
                    else if (i == 3)
                    {
                        break;
                    }
                    else
                    {
                        throw new DomainException("Opção Inválida selecionada!");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Valor Inválido: " + e.Message);
                    Console.WriteLine("Aperte Enter pra continuar");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
