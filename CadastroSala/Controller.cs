using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CadastroSala
{
    internal class Controller
    {
        public Controller() 
        { 
            
        }

        public void menuInicial(SalaDeAula sala)
        {
            SalaDeAula essaSala = new SalaDeAula(sala.numTurma, sala.getSerie());
            Console.Clear();
            Console.WriteLine("Turma {0} | {1}ª Série", sala.numTurma, sala.getSerie());
            Console.WriteLine();
            Console.WriteLine("[1] Cadastrar Novo Aluno");
            Console.WriteLine("[2] Alunos Cadastrados");
            Console.WriteLine("[3] Notas da turma");
            Console.WriteLine("[4] Sair");
            Console.WriteLine();
            Console.WriteLine("Digite a opção desejada:");
        }
    }
}
