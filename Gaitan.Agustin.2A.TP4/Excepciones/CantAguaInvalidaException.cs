using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantAguaInvalidaException : Exception
    {

        public CantAguaInvalidaException()
            : base("Error. Cantidad de agua inválida.\n")
        {

        }

    }
}
