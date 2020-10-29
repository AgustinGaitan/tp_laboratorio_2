using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Clase derivada de Exception
    /// </summary>
    public class NacionalidadInvalidaException : Exception
    {

        /// <summary>
        /// Constructor por defecto
        public NacionalidadInvalidaException()
            : base("La nacionalidad no se condice con el número de DNI.")
        {

        }

        /// <summary>
        /// Constructor con mensaje
        /// </summary>
        /// <param name="mensaje">Mensaje de error</param>
        public NacionalidadInvalidaException(string mensaje)
           : base(mensaje)
        {

        }


    }
}
