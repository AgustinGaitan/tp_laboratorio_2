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
    public class DniInvalidoException : Exception
    {

        /// <summary>
        /// Constructor con mensaje
        /// </summary>
        public DniInvalidoException()
            : base("Error. DNI invalido")
        {

        }

        /// <summary>
        /// Consctructor con excepcion
        /// </summary>
        /// <param name="e">Excepcion</param>
        public DniInvalidoException(Exception e)
            : base(e.ToString())
        {

        }

        /// <summary>
        /// Constructor con mensaje
        /// </summary>
        /// <param name="mensaje">Mensaje de error</param>
        public DniInvalidoException(string mensaje)
            : base(mensaje)
        {

        }

        /// <summary>
        /// Constructor con mensaje y excepcion
        /// </summary>
        /// <param name="mensaje">Mensaje de excepcion</param>
        /// <param name="excepcion">Excepcion</param>
        public DniInvalidoException(string mensaje, Exception excepcion)
            : base(mensaje, excepcion)
        {

        }





    }
}
