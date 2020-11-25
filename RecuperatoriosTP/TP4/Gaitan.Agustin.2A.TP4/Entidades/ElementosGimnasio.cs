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
        #region Atributos
        protected int id;
        protected string nombre;
        protected int precio;
        protected int caracteristica;
        private string color;
        #endregion

        #region Propiedades
        /// <summary>
        /// propiedad de solo lectura que retorna la id
        /// </summary>
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        /// <summary>
        /// propiedad de solo lectura que retorna la id
        /// </summary>

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        /// <summary>
        /// propiedad de lectura y escritura que retorna el precio y
        /// lo agrega.
        /// </summary>
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

        /// <summary>
        /// propiedad de lectura y escritura que retorna el nombre y
        /// lo agrega.
        /// </summary>
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
        /// <summary>
        /// propiedad de lectura y escritura que retorna la caracteristica y
        /// lo agrega.
        /// </summary>
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

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por default
        /// </summary>
        public ElementosGimnasio()
        {
            

        }

        /// <summary>
        /// Constructor con parametro
        /// </summary>
        /// <param name="caracteristica">caracteristica del elemento</param>
        public ElementosGimnasio(int caracteristica)
        {

            this.Caracteristica = caracteristica;


        }


        public ElementosGimnasio(int id, string nombre, int precio)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Precio = precio;

        }
        /// <summary>
        /// Constructor con parametro
        /// </summary>
        /// <param name="id">id del producto</param>
        /// <param name="nombre">nombre del producto</param>
        /// <param name="color">color del producto</param>
        /// <param name="precio">precio del producto</param>
        public ElementosGimnasio(int id, string nombre, string color, int precio):this(id,nombre,precio)
        {
         
            this.Color = color;

        }

        /// <summary>
        /// Constructor con parametro
        /// </summary>
        /// <param name="id">id del producto</param>
        /// <param name="nombre">nombre del producto</param>
        /// <param name="caracteristica">caracteristica del producto</param>
        /// <param name="precio">precio del producto</param>
        public ElementosGimnasio(int id, string nombre, int caracteristica, int precio):this(id,nombre,precio)
        {
           
            this.Caracteristica = caracteristica;
           

        }

        /// <summary>
        /// metodo estatico que guarda el elemento
        /// en un .txt
        /// </summary>
        /// <param name="elementos">elemento a guardar</param>
        /// <returns></returns>
        /// 
        public ElementosGimnasio(string color)
        {
            this.Color = color;

        }


        #endregion

        #region Metodos
        public static bool Guardar(ElementosGimnasio elementos)
        {
            Texto t = new Texto();
            return t.Guardar("elementos.txt", elementos.ToString());
        }

        /// <summary>
        /// metodo estatico que lee un .txt
        /// </summary>
        /// <returns>los datos leidos</returns>
        public static string Leer()
        {
            Texto nuevoTexto = new Texto();
            nuevoTexto.Leer("elementos.txt", out string datos);

            return datos;
        }

        /// <summary>
        /// Sobreescritura de ToString
        /// </summary>
        /// <returns>la informacion del producto</returns>
        public override string ToString()  
        {
            return this.MostrarDatos();
        }

        protected virtual string MostrarDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {this.Nombre}\n");
            sb.AppendFormat($"Precio: {this.Precio}\n");
            

            return sb.ToString();

        }

        #endregion
    }
}
