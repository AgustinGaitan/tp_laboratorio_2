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
            this.clasesDelDia = new Queue<EClases>();
            _randomClases();
        }

       

        private void _randomClases()
        {
            for(int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((EClases)Profesor.random.Next(0,3));
            }
           
            
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());

            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA :");
            foreach(EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString())
            }

            return sb.ToString();
           
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

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
