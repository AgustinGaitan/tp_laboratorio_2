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
    public class SinProfesorException : Exception
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public SinProfesorException()
            :base("No hay Profesor para la clase.")
        {

        }

        /// <summary>
        /// Constructor con mensaje y excepcion
        /// </summary>
        /// <param name="mensaje">Mensaje de error</param>
        /// <param name="e">Excepcion</param>
        public SinProfesorException(string mensaje, Exception e)
            : base(mensaje)
        {

        }
    }
}
