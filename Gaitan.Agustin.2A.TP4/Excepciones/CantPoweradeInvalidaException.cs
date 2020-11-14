using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantPoweradeInvalidaException : Exception
    {

        public CantPoweradeInvalidaException()
            : base("Error. Cantidad de Powerade inválida.\n")
        {

        }

    }
}
