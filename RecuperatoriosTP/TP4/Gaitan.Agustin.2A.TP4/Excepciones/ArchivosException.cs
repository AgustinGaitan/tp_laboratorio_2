using System;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Constructor por default que tiene mensaje de error.
        /// </summary>
        public ArchivosException()
            : base("Error con los archivos.")
        {

        }
    }
}
