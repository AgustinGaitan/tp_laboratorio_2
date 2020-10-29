﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException()
            :base("Error. Alumno repetido.")
        {

        }

        public AlumnoRepetidoException(string mensaje, Exception e)
            :base(mensaje)
        {

        }
    }
}