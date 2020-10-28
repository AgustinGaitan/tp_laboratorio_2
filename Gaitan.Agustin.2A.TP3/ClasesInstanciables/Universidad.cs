using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;

        public enum EClases
        {
            Programacion,Laboratorio,Legislacion,SPD
        }
    }
}
