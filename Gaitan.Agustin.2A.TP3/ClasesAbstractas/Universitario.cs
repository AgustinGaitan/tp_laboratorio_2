using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public Universitario()
            :base()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        protected abstract string ParticiparEnClase();


        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
                if ((pg1.legajo == pg2.legajo) || (pg1.DNI == pg2.DNI))
                {
                    return true;
                }
           
            return false;

        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }


        protected virtual string MostrarDatos()
        {    
                return base.ToString() + "LEGAJO: " + this.legajo;
        }


        public override bool Equals(object obj)
        {
            bool rta = false;

            if(obj is Universitario)
            {
                if(((Universitario)this) == ((Universitario)obj))
                {
                    rta = true;
                }
            }

            return rta;

        }


    }
}
