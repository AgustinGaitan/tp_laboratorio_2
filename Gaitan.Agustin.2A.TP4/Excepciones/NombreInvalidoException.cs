using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException()
            : base("Error. Nombre invalido.\n")
        {

        }
    }
}
