using Excepciones;
using System.Text;

namespace Entidades
{
    public class Mancuerna : Barra
    {

        private EPeso peso;
       
        public EPeso Peso
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

        public Mancuerna(EPeso peso) : base()
        {
            
            this.Peso = peso;
            this.idProducto = 2;
             

        }

        private EPeso ValidarPeso(EPeso peso)
        {

            switch (peso)
            {
                case EPeso.Liviana:
                    this.Precio = 1000;
                    break;
                case EPeso.Media:
                    this.Precio = 2000;
                    break;
                case EPeso.Pesada:
                    this.Precio = 4000;
                    break;

            }


            return peso;

        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Mancuerna : {this.Peso.ToString()} \n");



            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}




