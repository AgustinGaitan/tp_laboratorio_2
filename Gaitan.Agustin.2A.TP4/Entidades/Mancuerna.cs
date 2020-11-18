using Excepciones;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase que deriva de ElementosGimnasio
    /// </summary>
    public class Mancuerna : ElementosGimnasio
    {

      
        /// <summary>
        /// Constructor por default
        /// </summary>
        public Mancuerna()
            : base()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="peso">Peso de la mancuerna</param>
        public Mancuerna(int peso):base(peso)
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <param name="peso">Peso de la mancuerna</param>
        public Mancuerna(int id, int peso) : base(id, "mancuerna", peso, 0)
        {
            


        }

        /// <summary>
        /// Muestra los datos 
        /// </summary>
        /// <returns>String con los datos</returns>
        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Mancuerna de : {this.Caracteristica} KGs.\n");



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




