using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantMaxInvalidaException : Exception
    {

        public CantMaxInvalidaException()
            : base("Error. Cantidad maxima inválida.\n")
        {

        }

    }
}
