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


        public enum ENacionalidad
        {
            Argentino,Extranjero
        }

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

        public long DNI
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

        public string StringToDNI
        {
            set
            { 

            }
        }



        public Persona()
        {

        }

        public Persona(string nombre, string apellido,ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {

        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {

            return this.ValidarDni(nacionalidad, Convert.ToInt32(dato));

        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dniAInt = Convert.ToInt32(dato);
            int retorno = -1;
 
           if((dato.Length >= 0 && dato.Length <= 8)  && (!(dato.Any(char.IsLetter) && dato.Any(char.IsSymbol)))) 
           {    
                if((nacionalidad == ENacionalidad.Argentino && dniAInt >= 1 && dniAInt <= 89999999) ||
                    nacionalidad == ENacionalidad.Extranjero && dniAInt >= 90000000 && dniAInt <= 99999999)
                {

                    retorno = dniAInt;
                        
                }
                else
                {
                    throw new NacionalidadInvalidaException("Error.Nacionalidad inválida.");
                }
           
           }
           else
           {    

                throw new DniInvalidoException("Error. Dni inválido.");
                
           }

            return retorno;
        }
    }

}
