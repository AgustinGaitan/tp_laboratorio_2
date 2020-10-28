using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClasesInstanciables.Universidad;

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
           
        }


    }
}
