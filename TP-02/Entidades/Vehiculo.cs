using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo   //ARREGLADO : CLASE ABSTRACTA.
    {
        public enum EMarca          //ARREGLADO: ENUMERADOS PUBLICOS
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio //ARREGLADO: ENUMERADOS PUBLICOS
        {
            Chico, Mediano, Grande
        }

        private string chasis;
        private ConsoleColor color;
        private EMarca marca;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="chasis">Chasis del vehiculo</param>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="color">Color del vehiculo</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color) //HECHO CONSTRUCTOR
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;

        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio   //ARREGLADO: Abstract
        {
            get; 
           
            
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar() //ARREGLADO: AGREGADO VIRTUAL.
        {
        

            return (string)this;

        }

        public static explicit operator string(Vehiculo p)   //ARREGLADO: PUBLICO Y APPEND FORMAT.
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2) 
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)  //ARREGLADO : return !(v1.chasis == v2.chasis);
        {
            return !(v1.chasis == v2.chasis);
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if(obj is Vehiculo)
            {
                rta = this == (Vehiculo)obj;
            }

            return rta;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
