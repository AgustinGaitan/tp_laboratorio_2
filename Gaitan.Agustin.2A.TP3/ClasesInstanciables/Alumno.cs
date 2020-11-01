using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase sellada que deriva de Universitario
    /// </summary>
    public sealed class Alumno : Universitario
    {

       private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        /// <summary>
        /// Enumerado publico 
        /// </summary>
        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }
        /// <summary>
        /// Constructor por defecto de Alumno, inicializa los atributos en 0 o datos vacíos.
        /// </summary>
        public Alumno()
            :this(0,"","","",0,0)
        {

        }

        /// <summary>
        /// Constructor con parámetros de Alumno. Reutiliza código.
        /// </summary>
        /// <param name="id">legajo del alumno</param>
        /// <param name="nombre">nombre del alumno</param>
        /// <param name="apellido">apellido del alumno</param>
        /// <param name="dni">dni del alumno</param>
        /// <param name="nacionalidad">nacionalidad del alumno</param>
        /// <param name="claseQueToma">clase que toma el alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">legajo del alumno</param>
        /// <param name="nombre">nombre del alumno</param>
        /// <param name="apellido">apellido del alumno</param>
        /// <param name="dni">dni del alumno</param>
        /// <param name="nacionalidad">nacionalidad del alumno</param>
        /// <param name="claseQueToma">clase que toma el alumno</param>
        /// <param name="estadoCuenta">estado de la cuenta del alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta)
            :this(id,nombre,apellido,dni,nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        /// <summary>
        /// Método sobreescrito
        /// </summary>
        /// <returns>La clase que toma</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("TOMA CLASES DE  ");
            sb.AppendLine(this.claseQueToma.ToString());
           

            return sb.ToString();
        }

        /// <summary>
        /// Método sobreescrito que muestra los datos del alumno.
        /// </summary>
        /// <returns>Cadena con los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());

            if(this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                sb.AppendLine("ESTADO DE CUENTA: Cuota al día.");
            }
            else
            {
                sb.AppendLine("ESTADO DE CUENTA: " + this.estadoCuenta);
            }
            sb.Append(this.ParticiparEnClase());

            return sb.ToString();
           
        }

        /// <summary>
        /// Método sobreescrito ToString
        /// </summary>
        /// <returns>Los datos del Alumno</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="a">Alumno a igualar</param>
        /// <param name="clase">Clase a igualar</param>
        /// <returns>True/False</returns>
        public static bool operator ==(Alumno a, EClases clase)
        {
            return (a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase);
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="a">Alumno a igualar</param>
        /// <param name="clase">Clase a igualar</param>
        /// <returns>True/False</returns>
        public static bool operator !=(Alumno a, EClases clase)
        {
            return !(a == clase);
        }
    }
}
