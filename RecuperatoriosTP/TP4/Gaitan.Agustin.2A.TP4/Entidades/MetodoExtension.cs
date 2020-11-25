using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace Entidades
{
    public static class MetodoExtension
    {

        /// <summary>
        /// metodo estatico para guadar en un .txt
        /// </summary>
        public static bool Guardar(this Venta venta)
        {
            Texto t = new Texto();
            return t.Guardar("ventas.txt", venta.ToString());
        }

        /// <summary>
        /// metodo estatico para leer un txt
        /// </summary>
        /// <returns>los datos leidos</returns>
        public static string Leer(this Venta venta)
        {
            Texto nuevoTexto = new Texto();
            nuevoTexto.Leer("ventas.txt", out string datos);

            return datos;
        }
    }
}
