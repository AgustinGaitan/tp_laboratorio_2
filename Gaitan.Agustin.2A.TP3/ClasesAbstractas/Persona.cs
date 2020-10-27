using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        #region Propiedades
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
                this.StringToDNI = value.ToString();
                 
            }

        }

        public string StringToDNI
        {
            set
            {
                int retornoDeMetodo = this.ValidarDni(this.Nacionalidad, value.ToString());

                this.dni = retornoDeMetodo;
                     
            }
        }


        #endregion

        public Persona()
        {

        }

        public Persona(string nombre, string apellido,ENacionalidad nacionalidad):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {       

            if ((nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999) ||
                nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
            {

                return dato;

            }
            else
            {
                throw new NacionalidadInvalidaException("Error. La nacionalidad no coincide con el DNI.");
            }

        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
 
           if((dato.Length >= 0 && dato.Length <= 8)  && (!(dato.Any(char.IsLetter) && dato.Any(char.IsSymbol)))) 
           {

                return this.ValidarDni(nacionalidad, dato);
           }
           else
           {    

                throw new DniInvalidoException("Error. Dni inválido.");
                
           }

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
