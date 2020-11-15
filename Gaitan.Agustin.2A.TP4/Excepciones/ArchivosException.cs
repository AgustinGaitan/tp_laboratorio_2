using System;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException()
            : base("Error con los archivos.")
        {

        }
    }
}
