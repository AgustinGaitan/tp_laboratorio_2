using System.Text;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Colchoneta : Barra
    {
        private EColor color;
        

        public EColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Colchoneta()
        {
        }

        public Colchoneta(EColor color) : base()
        {
            this.Color = color;
            this.idProducto = 3;
        }

        private EColor ValidarColor(EColor color)
        {

            switch (color)
            {
                case EColor.Azul:
                    this.Precio = 1000;
                    break;
                case EColor.Verde:
                    this.Precio = 2000;
                    break;
                case EColor.Violeta:
                    this.Precio = 4000;
                    break;

            }


            return color;

        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Colchoneta de color: {this.color}\n");

            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}
