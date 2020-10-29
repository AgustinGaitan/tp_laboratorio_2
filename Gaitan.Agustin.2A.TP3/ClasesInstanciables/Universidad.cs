using Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public enum EClases
        {
            Programacion,Laboratorio,Legislacion,SPD
        }

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

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> u = new Xml<Universidad>();

            return u.Guardar("universidad.xml", uni);
        }

        public Universidad Leer()
        {
            Xml<Universidad> u = new Xml<Universidad>();
            u.Leer("universidad.xml", out Universidad universidadXml);
            return universidadXml;
        }

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
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            if (!Object.Equals(g, null) && !Object.Equals(a, null))
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

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            if (!Object.Equals(g, null) && !Object.Equals(i, null))
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

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

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

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada nuevaJornada = new Jornada(clase, g == clase);

            foreach (Alumno item in g.Alumnos)
            {
                if (item == clase)
                {
                    nuevaJornada.Alumnos.Add(item); //ARREGLAR
                    break;
                }
            }

            if (nuevaJornada.Alumnos.Count > 0)
            {
                g.Jornadas.Add(nuevaJornada);
            }

            return g;
        }


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
