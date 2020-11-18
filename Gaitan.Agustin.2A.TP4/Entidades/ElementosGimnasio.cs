using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public class ElementosGimnasio
    {
        protected string nombre;
        protected int precio;
        protected int caracteristica;

        public int Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Caracteristica
        {
            get
            {
                return this.caracteristica;
            }
            set
            {
              
                 this.caracteristica = value;
                                
            }
        }


        public ElementosGimnasio()
        {
            

        }

        public ElementosGimnasio(string nombre, int caracteristica, int precio)
        {
            this.Caracteristica = caracteristica;
            this.Nombre = nombre;
            this.Precio = precio;

        }

        public static bool Guardar(ElementosGimnasio elementos)
        {
            Texto t = new Texto();
            return t.Guardar("elementos.txt", elementos.ToString());
        }

        public static string Leer()
        {
            Texto nuevoTexto = new Texto();
            nuevoTexto.Leer("elementos.txt", out string datos);

            return datos;
        }

        public override string ToString()  
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {this.Nombre}\n");
            sb.AppendFormat($"Caracteristica: {this.Caracteristica}\n");
            sb.AppendFormat($"Precio: {this.Precio}\n\n");
 
            sb.AppendLine("------------------------------------------");

            return sb.ToString();
        }
    }
}
