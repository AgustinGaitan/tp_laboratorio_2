using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class GimnasioLlenoException : Exception
    {

        public GimnasioLlenoException()
            : base("Error. Gimnasio lleno.\n")
        {

        }

    }
}
