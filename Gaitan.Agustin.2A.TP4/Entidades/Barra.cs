using Excepciones;
using System.Text;

namespace Entidades
{
   


    public class Barra : ElementosGimnasio
    {
        protected float longitud;

        public float Longitud
        {
            get
            {
                return this.longitud;
            }
            set
            {
                value = ValidarLongitud(value);
            }
        }

        public Barra()
        {

        }

        public Barra(int precio, float longitud,int idVenta) : base()
        {
            this.Longitud = longitud;
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Barra de: {this.Longitud} metros");

            return sb.ToString();

        }

        private float ValidarLongitud(float longitud)
        {
            float validado = 0;

            //si puede convertirlo lo retorna como numero
            if (float.TryParse(longitud.ToString(), out validado) && (longitud > 0 && longitud <= 5))
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
