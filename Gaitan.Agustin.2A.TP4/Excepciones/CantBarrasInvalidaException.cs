using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantBarrasInvalidaException : Exception
    {

        public CantBarrasInvalidaException()
            : base("Error. Cantidad de barras inválida.\n")
        {

        }

    }
}
