using System;

namespace Excepciones
{
    public class CantMaxElementosInvalidaException : Exception
    {
        public CantMaxElementosInvalidaException()
            : base("Error. Cantidad maxima de elementos invalida...\n")
        {

        }
    }
}
