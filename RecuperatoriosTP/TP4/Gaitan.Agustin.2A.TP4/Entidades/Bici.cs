using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bici : ElementosGimnasio
    {
    

        /// <summary>
        /// propiedad lectura y escritura
        /// </summary>
        public Bici()
            : base()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id">id del producto</param>
        /// <param name="nombre">nombre del producto</param>
        /// <param name="color">color</param>
        public Bici(int id, string nombre, string color, int precio)
            : base(id, "bici", color, 0)
        {
            
           
        }


        public Bici(string color):base(color)
        {

        }

        /// <summary>
        /// Muestra los datos 
        /// </summary>
        /// <returns>String con los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Bici color: : {this.Color}.\n");

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
