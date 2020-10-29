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
    public class Jornada
    {
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;

        

        public List <Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = new List<Alumno>(value); }
        }
        
        public EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }


        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(EClases clase, Profesor instructor)
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        public bool Guardar(Jornada jornada)
        {
            Texto nuevoTexto = new Texto();
            return nuevoTexto.Guardar("jornada.txt", jornada.ToString());
        }

        public string Leer()
        {
            Texto nuevoTexto = new Texto();
            nuevoTexto.Leer("jornada.txt", out string datos);

            return datos;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach(Alumno item in j.alumnos)
            {
                if(item == a)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }


    }
}
