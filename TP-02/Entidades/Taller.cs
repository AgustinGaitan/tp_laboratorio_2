using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString() //ARREGLADO: override.
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    //ARREGLADO: AÑADIDO IFs DENTRO DE CADA CASE, SINO, ENTRABA AUNQUE NO SEA DE SUSODICHO TIPO.
                    case ETipo.Sedan:
                        if(v is Sedan)       //Si v es de Sedan
                        {
                            sb.AppendLine(v.Mostrar());
                        }                       
                        break;

                    case ETipo.Ciclomotor:
                        if(v is Ciclomotor)//Si v es Ciclomotor
                        {
                            sb.AppendLine(v.Mostrar());
                        }                      
                        break;

                    case ETipo.SUV:
                        if(v is Suv) //Si v es SUV
                        {
                            sb.AppendLine(v.Mostrar());
                        }                      
                        break;

                    default:          
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            bool encontrado = false;

                    //Busca en el taller si existe ya ese vehiculo. En el caso de que  exista, no lo agrega.
                foreach (Vehiculo v in taller.vehiculos) //ARREGLADO: taller.vehiculos
                {
                    if (v == vehiculo)
                    {
                        encontrado = true;
                        break;
                    }

                }
                      
            if(!encontrado && taller.espacioDisponible > taller.vehiculos.Count()) //Si hay espacio y si no se encontró, lo agrega.
            {
                taller.vehiculos.Add(vehiculo);
                return taller;
            }

            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {

            //Busca en el taller(primer parametro) si existe dicho vehiculo(segundo parametro). Si existe, lo quita de la lista.
            foreach (Vehiculo v in taller.vehiculos) //ARREGLADO: taller.vehiculos
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(v);         
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
