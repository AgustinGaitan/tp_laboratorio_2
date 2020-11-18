using Excepciones;
using System.Text;
using Archivos;

namespace Entidades
{
   
    public class Barra : ElementosGimnasio
    {
        
        public Barra()         
        {
            
        }

        public Barra(int longitud):base(longitud)
        {

        }
        public Barra(int id, int longitud):base(id,"barra",longitud,0)
        {
          
  
        }



        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Barra de : {this.Caracteristica} Mts. \n");

            return sb.ToString();

        }

        //protected virtual int ValidarLongitud(int longitud)
        //{
        //    int validado = 0;

        //    if (int.TryParse(longitud.ToString(), out validado))
        //    {

        //        if (longitud > 0 && longitud <= 2)
        //        {
        //            this.Precio = 2000;
        //        }
        //        else if (longitud == 3)
        //        {
        //            this.Precio = 4000;
        //        }
        //        else
        //        {
        //            this.Precio = 7500;
        //        }

        //    }
        //    else
        //    {
        //        throw new LongitudInvalidaException();
        //    }

        //    return validado;
        //}


        public override string ToString()
        {
            return this.MostrarDatos();

        }

    }
}
