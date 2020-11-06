using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Entidades
{
    /// <summary>
    /// Clase Abstracta
    /// </summary>
    public abstract class Club : IAdministracion
    {
        protected int cuota;
        protected string nombre;
        protected List<Club> listaClubes;

        public abstract int Cuota
        {
            get;
            set;
            
        }

        public abstract string Nombre
        {
            get;
            set;
        }


        public Club()
        {
        
        }

        public Club(int cuota, string nombre)
        {
            this.cuota = cuota;
            this.nombre = nombre;
        }

        int IAdministracion.TotalFacturado()
        {
            int acum = 0;

            for(int i = 0;i < this.listaClubes.Count; i++)
            {
                 acum += this.Cuota;
            }

            return acum;
            
        }
      

        protected abstract string MostrarDatos();

        public abstract bool ValidarCuota(int cuota);

        public abstract string ValidarNombre(string nombre);

    }


}
