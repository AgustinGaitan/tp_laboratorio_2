using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Security.Policy;

namespace Entidades
{
    /// <summary>
    /// Clase pública que hereda de vehículo.
    /// </summary>
    public class Sedan : Vehiculo
    {
        private ETipo tipo;

        /// <summary>
        /// Enumerado ETipo
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }
        

        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="marca">Marca del Sedan</param>
        /// <param name="chasis">Chasis del Sedan</param>
        /// <param name="color">Color del Sedan</param>
        /// <param name="tipo">Tipo del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio //ARREGLADO: short -> ETamanio   // Protected -> Public
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// Método sellado
        /// </summary>
        /// <returns>Cadena con los datos.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0} \n", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();   //ARREGLADO: return sb; -> return sb.toString();
        }
    }
}
