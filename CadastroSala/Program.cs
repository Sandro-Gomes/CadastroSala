using System;
using System.ComponentModel.Design;

namespace CadastroSala
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SalaDeAula sala1 = new SalaDeAula(42, 6);
            Controller controller = new Controller();
            controller.MenuTurma(sala1);
        }
    }
}
