using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public static class MetodoExtension
    {
        public static string Informar(this FilaVaciaException e)
        {
            return "Error. No hay fila ...\n";
        }
    }
}
