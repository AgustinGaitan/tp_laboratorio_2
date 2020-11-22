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
            :base()
           
        {
        }

        /// <summary>
        /// Constructor con parametro
        /// </summary>
        /// <param name="color">color de la colchoneta</param>
        public Colchoneta(int id, string nombre, string color, int precio)
            : base(id, "colchoneta", color, 0)
        {
          
        }

        public Colchoneta(string color):base(color)
        {

        }


        /// <summary>
        /// Muestra los datos 
        /// </summary>
        /// <returns>String con los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Colchoneta color: {this.Color}.\n");

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
