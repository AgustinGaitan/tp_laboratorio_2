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
    public class Club
    {
        protected int cantAgua;
        protected int cantPowerade;
        protected int cantBarraEnergetica;
        protected string nombre;
        protected int cantMaxGyms;
        private List<Gimnasio> listaGimnasios;

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
        public int Agua
        {
            get
            {
                return this.cantAgua;
            }
            set
            {
                if (this.ValidarCantAgua(value))
                {
                    this.cantAgua = value;
                }
                else
                {
                    throw new CantAguaInvalidaException();
                }
            }
        }

        public int Powerade
        {
            get
            {
                return this.cantPowerade;
            }
            set
            {
                if (this.ValidarCantPowerade(value))
                {
                    this.cantAgua = value;
                }
                else
                {
                    throw new CantAguaInvalidaException();
                }
            }

        }

        public int BarraEnergetica
        {
            get
            {
                return this.cantBarraEnergetica;
            }
            set
            {
                this.cantBarraEnergetica = value;
            }

        }
        public Club()
        {
        
        }

        public Club(int cantAgua, int cantPowerade, int cantBarrasEnergeticas, string nombre)
        {
            this.Agua = cantAgua;
            this.Nombre = nombre;
            this.BarraEnergetica = cantBarrasEnergeticas;
        }

      
      

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            
            sb.AppendFormat("CANTIDAD DE BOTELLAS DE AGUA: {0}\n", this.Agua);
            sb.AppendFormat("CANTIDAD DE BOTELLAS DE POWERADE: {0}\n", this.Powerade);
            sb.AppendFormat("CANTIDAD DE BARRITAS ENERGETICAS: {0}\n", this.BarraEnergetica);

            return sb.ToString();
        }

        public bool ValidarCantAgua(int cantAgua)
        {
            int validado;

            //si puede convertirlo lo retorna como numero
            return (int.TryParse(cantAgua.ToString(), out validado) && (cantAgua >= 20 && cantAgua <= 30));

        }

        public bool ValidarCantPowerade(int cantPowerade)
        {
            int validado;

            //si puede convertirlo lo retorna como numero
            return (int.TryParse(cantPowerade.ToString(), out validado) && (cantPowerade >= 10 && cantPowerade <= 20));

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

        public static Club operator +(Club club , Gimnasio gym)
        {
            club.listaGimnasios = new List<Gimnasio>();

            if (club.listaGimnasios.Count < club.cantMaxGyms)
            {
                club.listaGimnasios.Add(gym);
            }
            else
            {
                throw new ClubLlenoException();
            }

            return club;
        }
        
    }


}
