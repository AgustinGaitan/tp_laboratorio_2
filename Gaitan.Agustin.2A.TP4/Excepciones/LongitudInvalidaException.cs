using System;

namespace Excepciones
{
    public class LongitudInvalidaException : Exception
    {

        public LongitudInvalidaException()
            : base("Error. Longitud inválida...\n")
        {

        }

    }
}
