using Excepciones;
using System.Text;

namespace Entidades
{
    public class Mancuerna : ElementosGimnasio
    {

        private int peso;
       
        public int Peso
        {
            get
            {
                return this.peso;
                
            }
            set
            {
                this.peso = this.ValidarPeso(value);
            }
        }

        public Mancuerna()
        {

        }

        public Mancuerna(int peso) : base()
        {
            
            this.Peso = peso;
            this.idProducto = 2;
             

        }

        private int ValidarPeso(int peso)
        {

            int validado = 0;

            if (int.TryParse(peso.ToString(), out validado))
            {


                if (peso > 0 && peso <= 2)
                {
                    this.Precio = 1000;
                }
                else if (peso >= 3 && peso <= 5)
                {
                    this.Precio = 2000;
                }
                else if (peso >= 6 && peso <= 10)
                {
                    this.Precio = 5000;
                }
            }
            else
            {
                throw new PesoInvalidoException();
            }


            return validado;

        }

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Mancuerna de : {this.Peso} KGs.\n");



            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}




