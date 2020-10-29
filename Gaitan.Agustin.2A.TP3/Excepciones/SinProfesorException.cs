using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {
        public SinProfesorException()
            :base("Error. Sin profesor.")
        {

        }

        public SinProfesorException(string mensaje, Exception e)
            : base(mensaje)
        {

        }
    }
}
