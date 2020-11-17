using Excepciones;
using System.Text;
using Archivos;

namespace Entidades
{
   
    public class Barra : Venta 
    {
        //protected int precio;
        private int longitud;
        protected int idProducto;

        public int Longitud
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

        public Barra(int longitud)
        {
            this.Longitud = longitud;
            this.idProducto = 1;
        }

        public static bool Guardar(Barra bar)
        {
            Xml<Barra> u = new Xml<Barra>();

            return u.Guardar("barra.xml", bar);
        }

        public Barra Leer()
        {
            Xml<Barra> u = new Xml<Barra>();
            u.Leer("barra.xml", out Barra barraXml); //out retorna el los datos leídos
            return barraXml;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Barra de : {this.Longitud} Mts. \n");

            return sb.ToString();

        }

        protected virtual int ValidarLongitud(int longitud)
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
