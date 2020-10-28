using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException()
            :base("Error en los archivos.")
        {

        }

        public ArchivosException(string mensaje):base(mensaje)
        {

        }

        public ArchivosException(Exception innerException)
        {

        }
    }
}
