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
    /// <summary>
    /// Clase sellada profesor que deriva de Universitario
    /// </summary>
 
    public sealed class Profesor : Universitario
    {
        private Queue<EClases> clasesDelDia;
        static Random random;

        /// <summary>
        /// Constructor estático de Profesor
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }

        /// <summary>
        /// Constructor por defecto de instancia.
        /// </summary>
        public Profesor()
            :this(0,null,null,null,default)
        {
            this.clasesDelDia = new Queue<EClases>();
        }

        /// <summary>
        /// Constructor con parámetros. Obtiene datos de la clase base.
        /// Inicializa la cola de clases del día.
        /// </summary>
        /// <param name="id">legajo del profesor</param>
        /// <param name="nombre"> nombre del profesor</param>
        /// <param name="apellido">apellido del profesor</param>
        /// <param name="dni">dni del profesor</param>
        /// <param name="nacionalidad">nacionalidad del profesor</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<EClases>();   //Inicializacion de la cola de clases
            _randomClases();
        }

       /// <summary>
       /// Método sin retorno que le asigna un numero random para los enumerados.
       /// </summary>

        private void _randomClases()
        {
            for(int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((EClases)Profesor.random.Next(0,3));  //Asigna un numero para los enumerados random
            }
           
            
        }
        /// <summary>
        /// Muestra los datos del profesor. Luego se los pasa a ToString
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Retorna un string con las clases que tiene el profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA :");
            foreach(EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
           
        }

        /// <summary>
        /// Sobrecarga de operador ==
        /// </summary>
        /// <param name="i">Profesor a ser igualado</param>
        /// <param name="clase">Clase a ser igualada</param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, EClases clase)
        {
            foreach(EClases item in i.clasesDelDia)
            {
                if(item == clase)                    //Si el item es igual a la clase, retorna true.
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Igualdad negada
        /// </summary>
        /// <param name="i">Profesor a ser igualado</param>
        /// <param name="clase">Clase a ser igualada</param>
        /// <returns></returns>
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
