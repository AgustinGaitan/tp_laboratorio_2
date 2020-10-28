using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<EClases> clasesDelDia;
        static Random random;


        static Profesor()
        {
            Profesor.random = new Random();
        }

        public Profesor()
            :this(0,null,null,null,default)
        {
            this.clasesDelDia = new Queue<EClases>();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this._randomClases();
        }

       

        private void _randomClases()
        {
            
           
            
        }

        public static bool operator ==(Profesor i, EClases clase)
        {
            foreach(EClases item in i.clasesDelDia)
            {
                if(item == clase)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }



    }
}
