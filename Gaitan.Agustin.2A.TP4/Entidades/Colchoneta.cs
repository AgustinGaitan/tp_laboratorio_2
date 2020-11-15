using System.Text;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Colchoneta : ElementosGimnasio
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

        public Colchoneta(int precio,EColor color,int id) : base()
        {
            this.Color = color;
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Color de la colchoneta: {this.color}");

            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}
