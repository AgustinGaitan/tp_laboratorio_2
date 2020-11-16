using Excepciones;
using System.Text;

namespace Entidades
{
   


    public class Barra : ElementosGimnasio
    {
        protected double longitud;

        public double Longitud
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

        public Barra()
        {

        }

        public Barra(int precio, double longitud,int idVenta) : base()
        {
            this.Longitud = longitud;
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Barra de: {this.Longitud} metros.\n");

            return sb.ToString();

        }

        private double ValidarLongitud(double longitud)
        {
            double validado = 0;

            //si puede convertirlo lo retorna como numero
            if (double.TryParse(longitud.ToString(), out validado) && (longitud > 0 && longitud <= 5))
            {
                return validado;
            }
            else
            {
                throw new LongitudInvalidaException();
            }


        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }

    }
}
