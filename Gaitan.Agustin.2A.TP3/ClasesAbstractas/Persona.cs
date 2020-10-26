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
        private ENacionalidad nacionalidad;
        private int dni;


        public enum ENacionalidad
        {
            Argentino,Extranjero
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {

                value = this.ValidarNombreApellido(value);
                value = this.nombre;

            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                value = this.ValidarNombreApellido(value);
                value = this.apellido;
            }

        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {

        
                value = this.nacionalidad;

            }

        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                value = this.ValidarDni(Nacionalidad, value);              
            }

        }

        public string StringToDNI
        {
            set
            {
                value = value.ToString();
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

            return this.ValidarDni(nacionalidad, dato.ToString());

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
                    throw new NacionalidadInvalidaException("Error. La nacionalidad no coincide con el DNI.");
                }
           
           }
           else
           {    

                throw new DniInvalidoException("Error. Dni inválido.");
                
           }

            return retorno;
        }

        private string ValidarNombreApellido(string dato)
        {
            if (dato.Any(char.IsLetter) && dato.Any(char.IsSymbol) && dato.Any(char.IsWhiteSpace))
            {
                return dato;
            }
            else
            {
                return "Error. Caracter inválido.\n";
            }
        }

        public override string ToString()
        {
            return "NOMBRE COMPLETO: " + this.Nombre + this.Apellido +
                "\nNACIONALIDAD: " + this.Nacionalidad + "\nDNI" + this.DNI;
        }
    }

}
