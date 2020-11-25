using System;

namespace Excepciones
{
    public class ProductoSinSeleccionarException : Exception
    {

        public ProductoSinSeleccionarException()
            : base("Error. No seleccionó un producto...\n")
        {

        }

    }
}
