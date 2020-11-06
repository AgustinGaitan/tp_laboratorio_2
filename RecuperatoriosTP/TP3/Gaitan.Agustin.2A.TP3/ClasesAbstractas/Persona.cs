using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase pública y abstracta
    /// </summary>
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        /// <summary>
        /// Enumerado público de nacionalidades.
        /// </summary>
        public enum ENacionalidad
        {
            Argentino,Extranjero
        }

        #region Propiedades

        /// <summary>
        /// Propiedad que retorna/setea el nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {

                this.nombre = this.ValidarNombreApellido(value);
                

            }
        }

        /// <summary>
        /// Propiedad que retorna/setea el apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
                
            }

        }

        /// <summary>
        /// Propiedad que retorna/setea la nacionalidad
        /// </summary>
  
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

        /// <summary>
        /// Propiedad que retorna/setea el DNI
        /// </summary>
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

        /// <summary>
        /// Propiedad que retorna/setea DNI tipo string
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
                     
            }
        }


        #endregion

        /// <summary>
        /// Constructor por defecto de Persona
        /// </summary>
        public Persona()
        {
            this.Nacionalidad = ENacionalidad.Argentino;
            this.Nombre = "";
            this.Apellido = "";
            this.DNI = 1;
        }

        /// <summary>
        /// Constructor con parámetros de Persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido,ENacionalidad nacionalidad):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Constructor con parámetros de Persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// 
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor con parámetros de Persona.
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }

        /// <summary>
        /// Método que valida el DNI (int)
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">DNI pasado como int.</param>
        /// <returns>El DNI validado</returns>
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

        /// <summary>
        /// Método para validar el DNI (string)
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">DNI a validar (string) </param>
        /// <returns>DNI Validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {

            int numeroDni = -1;

            if (!(int.TryParse(dato, out numeroDni)) || dato.Length < 1 || dato.Length > 8 )
            {
                throw new DniInvalidoException("El DNI no coincide con el formato");
            }
            return ValidarDni(nacionalidad, numeroDni);

        }

        /// <summary>
        /// Método para validar el nombre y apellido
        /// </summary>
        /// <param name="dato">Nombre/Apellido</param>
        /// <returns>Dato validado o Espacio vacío</returns>
        private string ValidarNombreApellido(string dato)
        {
            Regex regex = new Regex(@"[a-zA-Z]*");

            Match match = regex.Match(dato);

            if (match.Success)
            {
                return match.Value;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Sobrecarga de ToString
        /// </summary>
        /// <returns>Una cadena con los datos de la Persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("NOMBRE COMPLETO: ");
            sb.AppendLine(this.Apellido + ", "+ this.Nombre);
            sb.Append("NACIONALIDAD: ");
            sb.AppendLine(this.Nacionalidad.ToString());
            sb.AppendLine(" ");

            return sb.ToString();
        }
    }

}
