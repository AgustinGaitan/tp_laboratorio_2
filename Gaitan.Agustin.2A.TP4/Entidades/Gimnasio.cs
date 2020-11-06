using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace Entidades
{
    public class Gimnasio : Club
    {

        public override int Cuota
        {
            get
            {
                return this.cuota;
            }
            set
            {
                if(this.ValidarCuota(value))
                {
                    this.cuota = value;
                }
                else
                {
                    throw new CuotaInvalidaException();
                }
            }
        }

        public override string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = this.ValidarNombre(value);

            }
        }

        public Gimnasio(int cuota, string nombre)
            : base(cuota, nombre)
        {

        }

        public override bool ValidarCuota(int cuota)
        {
            int validado;
            bool retorno = false;

            if (int.TryParse(cuota.ToString(), out validado) && (cuota > 500 && cuota < 1500)) //si puede convertirlo lo retorna como numero
            {
                retorno = true;

            }        

            return retorno;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            
            sb.AppendFormat("PARTE DEL CLUB: {0}\n", this.Nombre);
            sb.AppendFormat("CUOTA: {0}\n", this.Cuota);

            return sb.ToString();

        }

        public override string ValidarNombre(string nombre)
        {
            Regex regex = new Regex(@"[a-zA-Z]*");

            Match match = regex.Match(nombre);

            if(match.Success)
            {
                return match.Value;
            }
            else
            {
                return "";
            }

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }

    }
}
