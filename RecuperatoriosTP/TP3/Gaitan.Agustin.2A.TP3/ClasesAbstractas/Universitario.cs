using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase pública, abstracta y deriva de Persona.
    /// </summary>
    public abstract class Universitario : Persona
    {
        private int legajo;

        /// <summary>
        /// Constructor por defecto de Universitario
        /// </summary>
        public Universitario()
            :base()
        {
            this.legajo = 0;
        }

        /// <summary>
        /// Constructor con parámetros de Universitario
        /// </summary>
        /// <param name="legajo">legajo del universitario</param>
        /// <param name="nombre">nombre del universitario</param>
        /// <param name="apellido">apellido del universitario</param>
        /// <param name="dni">DNI del universitario</param>
        /// <param name="nacionalidad">nacionalidad del universitario</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Método abstracto y protegido 
        /// </summary>
        /// <returns>String</returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="pg1">Universitario a comparar</param>
        /// <param name="pg2">Segundo universitario a comparar</param>
        /// <returns>True si tienen legajo o dni iguales, False si son distitnos</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            
            
                if ((pg1.legajo == pg2.legajo) || (pg1.DNI == pg2.DNI))
                {
                    return true;
                }
            
               
           
            return false;

        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="pg1">Universitario a comparar</param>
        /// <param name="pg2">Segundo universitario a comparar.</param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Método que muestra los datos del universitario
        /// </summary>
        /// <returns>Datos del universitario</returns>
        protected virtual string MostrarDatos()
        {    
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.Append("LEGAJO NÚMERO: ");
            sb.AppendLine(this.legajo.ToString());

            return sb.ToString();

        }

        /// <summary>
        /// Sobrecarga de Equals.
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>True si son iguales, False si son distintos</returns>
        public override bool Equals(object obj)
        {
            bool rta = false;

            if(obj is Universitario)
            {
                rta = this == (Universitario)obj;
            }

            return rta;

        }


    }
}
