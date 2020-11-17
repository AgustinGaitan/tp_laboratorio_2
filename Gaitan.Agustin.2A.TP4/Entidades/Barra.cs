using Excepciones;
using System.Text;

namespace Entidades
{
   
    public class Barra : Venta 
    {
        //protected int precio;
        private int peso;
        protected int idProducto;

        public int Longitud
        {
            get
            {
                return this.peso;
            }
            set
            {
                this.peso = ValidarLongitud(value);
            }
        }

        public int Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public Barra()
        {
            
        }

        public Barra(int longitud)
        {
            this.Longitud = longitud;
            this.idProducto = 1;
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Barra de : {this.Longitud} Mts. \n");

            return sb.ToString();

        }

        private int ValidarLongitud(int longitud)
        {
            int validado = 0;

            if (int.TryParse(longitud.ToString(), out validado))
            {


                if (longitud > 0 && longitud <= 2)
                {
                    this.Precio = 2000;
                }
                else if (longitud == 3)
                {
                    this.Precio = 4000;
                }
                else
                {
                    this.Precio = 1500 * longitud;
                }

            }
            else
            {
                throw new LongitudInvalidaException();
            }

            return validado;
        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }

    }
}
