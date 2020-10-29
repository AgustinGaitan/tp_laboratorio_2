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
    public class ArchivosException : Exception
    {

        /// <summary>
        /// Constructor por defecto con mensaje
        /// </summary>
        public ArchivosException()
            :base("Error en los archivos.")
        {

        }

        /// <summary>
        /// Constructor con mensaje
        /// </summary>
        /// <param name="mensaje">Mensaje de error</param>
        public ArchivosException(string mensaje):base(mensaje)
        {

        }

        /// <summary>
        /// Constructor con excepcion
        /// </summary>
        /// <param name="innerException">Excepcion</param>
        public ArchivosException(Exception innerException)
        {

        }
    }
}
