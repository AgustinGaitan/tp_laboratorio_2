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
        /// <summary>
        /// Método de extension
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string Informar(this FilaVaciaException e)
        {
            return "Error. No hay elementos en la grilla...\n";
        }
    }
}
