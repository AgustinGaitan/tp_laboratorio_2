using Excepciones;
using System.Text;
using Archivos;

namespace Entidades
{
   /// <summary>
   /// Clase que deriva de ElementosGimnasio
   /// </summary>
    public class Barra : ElementosGimnasio
    {
        /// <summary>
        /// Constructor por default
        /// </summary>
        public Barra()         
        {
            
        }

        /// <summary>
        /// Constructor con parametro
        /// </summary>
        /// <param name="longitud">Longitud de la barra</param>
        public Barra(int longitud):base(longitud)
        {

        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id">id del producto</param>
        /// <param name="longitud">longitud de la barra</param>
        public Barra(int id, int longitud):base(id,"barra",longitud,0)
        {
          
  
        }


        /// <summary>
        /// Muestra los datos 
        /// </summary>
        /// <returns>String con los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Barra de : {this.Caracteristica} Mts. \n");

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
