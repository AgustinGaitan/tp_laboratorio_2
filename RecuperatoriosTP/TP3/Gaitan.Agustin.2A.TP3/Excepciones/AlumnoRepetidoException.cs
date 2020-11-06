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
    public class AlumnoRepetidoException : Exception
    {
        /// <summary>
        /// Constructor por defecto de la excepcion
        /// </summary>
        public AlumnoRepetidoException()
            :base("Alumno repetido.")
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="mensaje">Mensaje</param>
        /// <param name="e">Excepcion</param>
        public AlumnoRepetidoException(string mensaje, Exception e)
            :base(mensaje)
        {

        }
    }
}
