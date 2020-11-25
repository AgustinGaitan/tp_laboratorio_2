using System;

namespace Excepciones
{
    public class FilaVaciaException : Exception
    {

        /// <summary>
        /// Constructor por default de excepcion
        /// </summary>
        public FilaVaciaException()
            : base("Error. No hay filas en la grilla.\n")
        {

        }

    }
}
