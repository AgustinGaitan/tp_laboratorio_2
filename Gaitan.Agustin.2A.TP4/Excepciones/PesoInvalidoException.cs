using System;

namespace Excepciones
{
    public class PesoInvalidoException : Exception
    {

        public PesoInvalidoException()
            : base("Error. Peso invalido...\n")
        {

        }

    }
}
