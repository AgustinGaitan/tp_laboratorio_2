using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Excepciones;
using System.Text.RegularExpressions;

namespace Entidades
{
    /// <summary>
    /// Clase Abstracta
    /// </summary>
    public abstract class ElementosGimnasio
    { 
 
        protected string nombre;
        protected int cantMax;
        private List<Barras> listaBarras;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = this.ValidarNombre(value);
            }
        }
        public int CantidadMaxima
        {
            get
            {
                return this.cantMax;
            }
            set
            {
                value = this.ValidarCantMax(value);            
            }
        }

        public ElementosGimnasio()
        {
        
        }

        public ElementosGimnasio(string nombre, int cantMax)
        {
            this.Nombre = nombre;
            this.CantidadMaxima = cantMax;
        }

      
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Nombre del gimnasio:{this.Nombre}\n");

            return sb.ToString();
        }     

        public int ValidarCantMax(int cant)
        {
            int validado=0;

            //si puede convertirlo lo retorna como numero
            if(int.TryParse(cant.ToString(), out validado) && (cant > 0 && cant <= 20))
            {
                return validado;
            }
            else
            {
                throw new CantMaxInvalidaException();
            }

        
        }

        public string ValidarNombre(string nombre)
        {
            Regex regex = new Regex(@"[a-zA-Z]*");

            Match match = regex.Match(nombre);

            if (match.Success)
            {
                return match.Value;
            }
            else
            {
                return "";
            }

        }

        public static ElementosGimnasio operator +(ElementosGimnasio gym , Barras elemento)
        {
            club.listaGimnasios = new List<Barras>();

            if (club.listaGimnasios.Count < club.cantMaxGyms)
            {
                club.listaGimnasios.Add(gym);
            }
            else
            {
                throw new GimnasioLlenoException();
            }

            return club;
        }
        
    }


}
