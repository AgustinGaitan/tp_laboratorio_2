﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CuotaInvalidaException : Exception
    {

        public CuotaInvalidaException()
            : base("Error. Cuota inválida.\n")
        {

        }

    }
}
