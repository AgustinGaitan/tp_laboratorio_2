using Excepciones;
using System.Text;

namespace Entidades
{
   
    public class Barra : Venta 
    {
        //protected int precio;
        private ELongitud longitud;
        protected int idProducto;

        public ELongitud Longitud
        {
            get
            {
                return this.longitud;
            }
            set
            {
                this.longitud = ValidarLongitud(value);
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

        public Barra(ELongitud longitud)
        {
            this.Longitud = longitud;
            this.idProducto = 1;
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Barra : {this.Longitud} \n");

            return sb.ToString();

        }

        private ELongitud ValidarLongitud(ELongitud longitud)
        {

            switch (longitud)
            {
                case ELongitud.Chica:
                    this.Precio = 1000;
                    break;
                case ELongitud.Mediana:
                    this.Precio = 3000;
                    break;
                case ELongitud.Larga:
                    this.Precio = 5000;
                    break;

            }


            return longitud;

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }

    }
}
