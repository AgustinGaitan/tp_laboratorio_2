using System;

namespace Excepciones
{
    public class FilaVaciaException : Exception
    {

        public FilaVaciaException()
            : base("Error. Fila vacía...\n")
        {

        }

    }
}
