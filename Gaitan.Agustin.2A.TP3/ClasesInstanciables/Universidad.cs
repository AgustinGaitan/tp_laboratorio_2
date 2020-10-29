using Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesInstanciables
{
    /// <summary>
    /// Clase pública universidad.
    /// </summary>
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        /// <summary>
        /// Enumerado público
        /// </summary>
        public enum EClases
        {
            Programacion,Laboratorio,Legislacion,SPD
        }

        /// <summary>
        /// Propiedad que retorna/setea al atributo alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = new List<Alumno>(value); 
            }
        }

        /// <summary>
        /// Propiedad que retorna/setea al atributo profesores.
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = new List<Profesor>(value);
            }
        }

        /// <summary>
        /// Propiedad que retorna/setea al atributo jornadas.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = new List<Jornada>(value);
            }
        }

        /// <summary>
        /// Propiedad que retorna/setea al atributo jornada mediante indexadores.
        /// </summary>
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }

        /// <summary>
        /// Constructor por defecto de Universidad
        /// </summary>
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();  //Inicializacion de la lista de Alumno
            this.jornada = new List<Jornada>(); ///Inicializacion de la lista de Jornada
            this.profesores = new List<Profesor>(); //Inicializacion de la lista de Profesor
        }

        /// <summary>
        /// Método que guarda un archivo 
        /// </summary>
        /// <param name="uni">Datos a guardar</param>
        /// <returns>True si se pudo guardar el archivo, False si no</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> u = new Xml<Universidad>();             

            return u.Guardar("universidad.xml", uni);            
        }

        /// <summary>
        /// Método que lee un archivo
        /// </summary>
        /// <returns>Datos del archivo Xml</returns>
        public Universidad Leer()
        {
            Xml<Universidad> u = new Xml<Universidad>();
            u.Leer("universidad.xml", out Universidad universidadXml); //out retorna el los datos leídos
            return universidadXml;
        }

        /// <summary>
        /// Muestra los datos de la universidad
        /// </summary>
        /// <param name="uni">Universidad</param>
        /// <returns>Cadena con los datos</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA:");
            foreach (Jornada item in uni.Jornadas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Método sobreescrito
        /// </summary>
        /// <returns>Datos de la universidad.</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="g">Universidad a igualar</param>
        /// <param name="a">Alumno a igualar</param>
        /// <returns>True si el alumno está inscripto. False si no</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            if (!Object.Equals(g, null) && !Object.Equals(a, null)) //si es distinto de null
            {
                foreach (Alumno item in g.Alumnos)
                {
                    if (a == item)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="g">Universidad a igualar</param>
        /// <param name="a">Alumno a igualar</param>
        /// <returns>True si el alumno no está inscripto. False si está</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="g">Universidad a igualar</param>
        /// <param name="a">Profesor a igualar</param>
        /// <returns>True si el profesor está dando clases en la Universidad . False si no</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            if (!Object.Equals(g, null) && !Object.Equals(i, null)) //si es distinto de null
            {
                foreach (Profesor item in g.Instructores)
                {
                    if (item == i)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="g">Universidad a igualar</param>
        /// <param name="a">Profesor a igualar</param>
        /// <returns>True si el profesor no está dando clases en la Universidad . False si las esta dando</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="u">Universidad a igualar</param>
        /// <param name="clase">Clase a igualar </param>
        /// <returns>Instructor que puede dar la clase.</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor instructorRetorno = null;

            foreach (Profesor item in u.Instructores)
            {
                if (item == clase)
                {
                    instructorRetorno = item;
                    break;
                }
            }
            if (Object.Equals(instructorRetorno, null))
            {
                throw new SinProfesorException();
            }

            return instructorRetorno;

        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="u">Universidad a igualar</param>
        /// <param name="clase">Clase a igualar</param>
        /// <returns>Profesor que no puede dar la clase</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor instructorRetorno = null;

            foreach (Profesor item in u.Instructores)
            {
                if (item != clase)
                {
                    instructorRetorno = item;
                    break;
                }
            }
            return instructorRetorno;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="g">Universidad que se le agregará una clase</param>
        /// <param name="clase">Clase a agregar</param>
        /// <returns>Universidad nueva</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada nuevaJornada = new Jornada(clase, g == clase); //se le carga g == clase en la jornada
         

            foreach (Alumno item in g.Alumnos)
            {
                if (item == clase)
                {
                    nuevaJornada.Alumnos.Add(item); 
                }
            }

            if (nuevaJornada.Alumnos.Count > 0)
            {
                g.Jornadas.Add(nuevaJornada);
            }

            return g;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="u">Universidad que se le agregara un alumno</param>
        /// <param name="a">Alumno a agregar</param>
        /// <returns>Universidad con alumno agregado</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return u;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="u">Universidad que se le agregará un profesor</param>
        /// <param name="i">Profesor a agregar</param>
        /// <returns>Universidad con profesor agregado</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {

            if (u != i)
            {
                u.Instructores.Add(i);
            }

            return u;
        }


    }
}
