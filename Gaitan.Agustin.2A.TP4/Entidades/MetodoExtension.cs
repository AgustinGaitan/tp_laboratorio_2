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
        public static string Informar(this CantMaxElementosInvalidaException e)
        {
            return "No caben mas elementos en ésta venta.\n";
        }
    }
}
