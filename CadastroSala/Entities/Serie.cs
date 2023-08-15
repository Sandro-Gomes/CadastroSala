using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala.Entities
{
    internal class Serie
    {
        public List<Materia> Materias = new List<Materia>();

        public Serie()
        {
            //Declara todas as matérias da sala de aula.
            Materias.Add(new Materia("Portugues", 1));
            Materias.Add(new Materia("Matematica", 2));
            Materias.Add(new Materia("Historia", 3));
            Materias.Add(new Materia("Geografia", 4));
            Materias.Add(new Materia("Ciencias", 5));
        }

        
        
    }
}
