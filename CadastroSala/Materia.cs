using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala
{
    class Materia
    {
        public string nomeMateria;
        public double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
        public readonly double notaMaxima = 10;
        public readonly double mediaNecessaria = 6;
        public double mediaFinal = 0;

        public Materia()
        {

        }
        public Materia(string materia)
        {
            nomeMateria = materia;
        }

        public double calcularMedia(double n1, double n2, double n3, double n4)
        {
            double total = (n1 + n2 + n3 + n4) / 4;
            return total;
        }
    }
}
