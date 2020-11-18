using System.Text;
using System.Text.RegularExpressions;
using Excepciones;

namespace Entidades
{
    /// <summary>
    /// Clase que deriva de ElementosGimnasio
    /// </summary>
    public class Colchoneta : ElementosGimnasio
    {
       
        /// <summary>
        /// Constructor por default
        /// </summary>
        public Colchoneta()
           
        {
        }

        /// <summary>
        /// Constructor con parametro
        /// </summary>
        /// <param name="longitud">Longitud de la colchoneta</param>
        public Colchoneta(int longitud) : base(longitud)
        {

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <param name="peso">Longitud de la colchoneta</param>
        public Colchoneta(int id, int longitud) : base(id, "colchoneta", longitud, 0)
        {
    
        }

        /// <summary>
        /// Muestra los datos 
        /// </summary>
        /// <returns>String con los datos</returns>
        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Colchoneta de : {this.Caracteristica} metros.\n");

            return sb.ToString();

        }


        /// <summary>
        /// Override de ToString para acceder publicamente a la informacion del objeto
        /// </summary>
        /// <returns>Informacion del objeto</returns>
        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}
