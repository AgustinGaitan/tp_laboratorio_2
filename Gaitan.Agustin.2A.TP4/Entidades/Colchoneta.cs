using System.Text;
using System.Text.RegularExpressions;
using Excepciones;

namespace Entidades
{
    public class Colchoneta : ElementosGimnasio
    {
       

        public Colchoneta()
            : base()
        {
        }

        public Colchoneta(int longitud) : base()
        {
            this.Caracteristica = longitud;
 
        }

        //protected int ValidarLongitud(int longitud)
        //{
        //    int validado = 0;

        //    if (int.TryParse(longitud.ToString(), out validado))
        //    {


        //        if (longitud > 0 && longitud <= 2)
        //        {
        //            this.Precio = 1000;
        //        }
        //        else if (longitud == 3)
        //        {
        //            this.Precio = 3000;
        //        }
        //        else
        //        {
        //            this.Precio = 5000;
        //        }

        //    }
        //    else
        //    {
        //        throw new LongitudInvalidaException();
        //    }

        //    return validado;
        //}

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Colchoneta de : {this.Caracteristica} metros.\n");

            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}
