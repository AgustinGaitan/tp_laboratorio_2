using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CaracteristicaSinSeleccionarException : Exception
    {
        public CaracteristicaSinSeleccionarException()
            : base("Error. Caracteristica sin seleccionar...")
        {

        }
    }
}
