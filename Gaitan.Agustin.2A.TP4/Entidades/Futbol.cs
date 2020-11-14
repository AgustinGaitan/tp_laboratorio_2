using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Futbol : Club
    {
      
        public Futbol()            
        {
        }

        public Futbol(int cantAgua, int cantPowerade, int cantBarrasEnergeticas, string nombre)
            : base(cantAgua, cantPowerade, cantBarrasEnergeticas, nombre)
        {
            
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat("PARTE DEL CLUB: {0}\n", this.Nombre);
            sb.Append(base.MostrarDatos());

            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}
