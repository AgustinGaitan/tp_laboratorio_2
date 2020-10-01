using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase publica que hereda de vehículo.
    /// </summary>
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor de 3 parametros
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            :base(chasis,marca,color)
        {
        }

        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio  //ARREGLADO : Protected -> Public // override // short -> ETamanio
        {
            get
            {
                return ETamanio.Chico;  //Arreglado.
            }
        }

        /// <summary>
        /// Método sellado.
        /// </summary>
        /// <returns>Cadena con los datos.</returns>
        public override sealed string Mostrar() //ARREGLADO : private -> public
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar()); 
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString(); //ARREGLADO: .ToString()
        }
    }
}
