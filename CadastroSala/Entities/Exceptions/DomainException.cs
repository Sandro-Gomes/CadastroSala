using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSala.Entities.Exceptions
{
    public class DomainException : ArgumentException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
