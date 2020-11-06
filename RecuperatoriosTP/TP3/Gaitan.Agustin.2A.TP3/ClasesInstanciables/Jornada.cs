using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClasesInstanciables.Universidad;
using Archivos;
using System.CodeDom;
using System.ComponentModel;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase pública
    /// </summary>
    public class Jornada
    {
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;

        /// <summary>
        /// Propiedad que retorna/setea el atributo alumnos
        /// </summary>

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set 
            { 
                this.alumnos = new List<Alumno>(value); 
            }
        }
        /// <summary>
        /// Propiedad que retorna/setea el atributo clase 
        /// </summary>
        public EClases Clase
        {
            get
            {  return this.clase; }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna/setea el atributo instructor
        /// </summary>
        public Profesor Instructor
        {
            get { return this.instructor; }
            set
            {
                this.instructor = value;
            }
        }

        /// <summary>
        /// Constructor privado por defecto de Jornada e inicializa la lista de alumnos.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor publico con parametros de Jornada
        /// </summary>
        /// <param name="clase">Clase</param>
        /// <param name="instructor">Instructor</param>
        public Jornada(EClases clase, Profesor instructor):this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        /// <summary>
        /// Método estático que guarda archivos
        /// </summary>
        /// <param name="jornada">Jornada a guardar en un archivo .txt</param>
        /// <returns>True si se pudo guardar, false si no.</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto nuevoTexto = new Texto();
            return nuevoTexto.Guardar("jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Método estático que lee archivos
        /// </summary>
        /// <returns>los datos leídos</returns>
        public static string Leer()    //Arreglado RECUPERATORIO. Faltaba "static".
        {
            Texto nuevoTexto = new Texto();
            nuevoTexto.Leer("jornada.txt", out string datos);

            return datos;
        }

        /// <summary>
        /// Sobrecarga del operador == . Reutiliza código.
        /// </summary>
        /// <param name="j">Jornada a igualar</param>
        /// <param name="a">Alumno a igualar</param>
        /// <returns>True si el alumno pertenece a la clase. False si no</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {

            return a == j.Clase;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="j">Jornada a igualar</param>
        /// <param name="a">Alumno a igualar</param>
        /// <returns>True si el alumno no pertenece a la clase. False si no</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="j">Jornada</param>
        /// <param name="a">Alumno a agregar</param>
        /// <returns>Jornada con o sin alumno añadido</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.Alumnos.Add(a);
            }

            return j;
        }

        /// <summary>
        /// Método sobreescrito ToString
        /// </summary>
        /// <returns>Cadena con los datos de la Jornada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("CLASE DE ");
            sb.Append(this.Clase.ToString() +" ");
            sb.Append("POR ");
            sb.Append(this.Instructor.ToString());
            sb.AppendLine("\nALUMNOS:");

            foreach (Alumno item in this.Alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("<------------------------------------------------------->");

            return sb.ToString();
        }

    }
}
