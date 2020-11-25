using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoSePudoGuardarException : Exception
    {
        /// <summary>
        /// Constructor por default con mensaje de error.
        /// </summary>
        public NoSePudoGuardarException()
            : base("No se pudo guardar el archivo. No hay filas...")
        {

        }
    }
}
