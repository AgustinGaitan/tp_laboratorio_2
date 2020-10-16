using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string nacionalidad;
        private long dni;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }

        }

        public string Nacionalidad
        {
            get 
            {
                return this.nacionalidad;
            }
            set 
            { 
                

            }

        }

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                

                if((value > 0 && value < 90000000) && (this.Nacionalidad == "argentino"))
                {
                    this.dni = value;
                }
                else if((value >= 90000000 && value < 100000000) && (this.Nacionalidad == "extranjero"))
                {
                    this.dni = value;
                }
                else
                {
                    throw 
                }

            }

        }


        public Persona(string nombre, string apellido, string nacionalidad, int dni)
        {

        }
    }

}
