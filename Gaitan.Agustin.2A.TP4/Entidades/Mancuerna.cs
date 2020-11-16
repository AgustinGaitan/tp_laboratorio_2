using Excepciones;
using System.Text;

namespace Entidades
{
    public class Mancuerna : ElementosGimnasio
    {

        private int peso;


        private int Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                this.peso = value;
            }
        }
        public Mancuerna()
        {

        }

        public Mancuerna(int precio, int peso,int idVenta) : base()
        {
            this.Peso = peso;

        }

        private float ValidarPeso(int peso)
        {
            int validado = 0;

            //si puede convertirlo lo retorna como numero
            if (int.TryParse(peso.ToString(), out validado) && (peso > 0 && peso <= 40))
            {
                return validado;
            }
            else
            {
                throw new PesoInvalidoException();
            }


        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Mancuerna de: {this.Peso} kilogramos.\n");



            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}




