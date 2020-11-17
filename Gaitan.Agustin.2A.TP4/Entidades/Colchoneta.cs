using System.Text;
using System.Text.RegularExpressions;
using Excepciones;

namespace Entidades
{
    public class Colchoneta : Barra
    {
        private string color;
        

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = this.ValidarColor(value) ;
            }
        }

        public Colchoneta()
        {
        }

        public Colchoneta(string color) : base()
        {
            this.Color = color;
            this.idProducto = 3;
        }

        private string ValidarColor(string color)
        {

            if(color == "Azul" || color == "Rojo" || color == "Verde")
            {
                this.Precio = 1000;
            }
            else
            {
                throw new ColorInvalidoException();
            }

            return color;

        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Colchoneta de color: {this.Color}\n");

            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}
