using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
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
            set
            {

                if (!(value.Any(char.IsDigit)) && !(value.Any(char.IsSymbol)))
                {
                    this.nombre = value;
                }
                else
                {

                }

            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (!(value.Any(char.IsDigit)) && !(value.Any(char.IsSymbol)))
                {
                    this.apellido = value;
                }
            }

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


                if ((value > 0 && value < 90000000) && (this.Nacionalidad == "argentino"))
                {
                    this.dni = value;
                }
                else if ((value >= 90000000 && value < 100000000) && (this.Nacionalidad == "extranjero"))
                {
                    this.dni = value;
                }
                else
                {
                    throw new DniInvalidoException("Error. DNI inválido.");
                }

            }

        }


        public Persona(string nombre, string apellido, string nacionalidad, int dni)
        {

        }
    }

}
