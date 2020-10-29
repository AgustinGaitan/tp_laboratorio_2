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

                this.nombre = this.ValidarNombreApellido(value);
                

            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
                
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


                this.nacionalidad = value;

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
                this.dni = ValidarDni(this.Nacionalidad, value);
                 
            }

        }

        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
                     
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

            int numeroDni = -1;

            if (dato.Length < 1 || dato.Length > 8 || !int.TryParse(dato, out numeroDni))
            {
                throw new DniInvalidoException("El DNI no coincide con el formato");
            }
            return ValidarDni(nacionalidad, numeroDni);

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
