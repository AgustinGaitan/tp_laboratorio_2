using System;

namespace Excepciones
{
    public class CantBarrasInvalidaException : Exception
    {

        public CantBarrasInvalidaException()
            : base("Error. Cantidad de barras inválida.\n")
        {

        }

    }
}
