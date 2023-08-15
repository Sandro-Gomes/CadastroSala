using CadastroSala.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala.Entities
{
    class Materia
    {
        public string NomeMateria { get; set; }
        public int IdMateria { get; set; }
        public double[] NotaBimestre { get; private set; } = new double[4];
        public double NotaMaxima { get; private set; }
        public double MediaNecessaria { get; private set; }
        public double MediaFinal { get; private set; }

        public Materia()
        {

        }

        public Materia(string nomeMateria, int idMateria)
        {
            NomeMateria = nomeMateria;
            IdMateria = idMateria;

        }

        public double calcularMedia()
        {
            double somaNotas = 0;
            for(int i = 0;i <NotaBimestre.Length;i++)
            {
                somaNotas += NotaBimestre[i];
            }
            return somaNotas / NotaBimestre.Length;
            
        }

        public void AlterarNota(double nota, int bimestre)
        {
            if (bimestre > NotaBimestre.Length || bimestre < 0) {
                throw new DomainException("Digite um bimestre válido!");
            }
            NotaBimestre[bimestre - 1] = nota;
        }
        
    }
}
