using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase pública que hereda de vehículo.
    /// </summary>
    public class Suv : Vehiculo  //ARREGLADO : HEREDA DE VEHICULO
    {
        /// <summary>
        /// Constructor de 3 parametros.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)  //no hace falta tener nada dentro 
            : base(chasis,marca,color)
        {
        }
        /// <summary>
        /// SUV son grandes.
        /// </summary>
        protected override ETamanio Tamanio  //ARREGLADO: CAMBIADO A PUBLICO PARA SER SOBREESCRITO
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Método sellado que muestra los datos.
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio); //ARREGLADO: AppendLine -> AppendFormat
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString(); //ARREGLADO: return sb -> return sb.ToString();
        } 
    }
}
