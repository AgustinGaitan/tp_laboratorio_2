using Excepciones;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Archivos;
namespace Entidades
{
    /// <summary>
    /// Clase Abstracta
    /// </summary>
    /// 

    //interfaces//
    //generics;//
    //serializar;//
    //archivos;
    //base de datos;
    //metodo de extension;
    //hilos;
    //excepciones;//
    //test unitarios;
    //delegados y eventos


    public class ElementosGimnasio
    {
        protected int idVenta;
        protected int precio;
        private int cantMaxBarras;
        private int cantMaxMancuernas;
        private int cantMaxColchonetas;
        private List<Barra> listaBarras;
        private List<Mancuerna> listaMancuernas;
        private List<Colchoneta> listaColchonetas;

        public int CantidadMaximaMancuernas
        {
            get
            {
                return this.cantMaxMancuernas;
            }
            set
            {
                this.cantMaxMancuernas = this.ValidarCantMax(value);
            }
        }

        public int CantidadMaximaBarras
        {
            get
            {
                return this.cantMaxBarras;
            }
            set
            {
                this.cantMaxBarras = this.ValidarCantMax(value);
            }
        }


        public int CantidadMaximaColchonetas
        {
            get
            {
                return this.cantMaxColchonetas;
            }
            set
            {
                this.cantMaxColchonetas = this.ValidarCantMax(value);
            }
        }

        public ElementosGimnasio()
        {
            
        }


        public ElementosGimnasio(int cantMaxMancuernas, int cantMaxBarras, int cantMaxColchonetas,int id)
        {
            this.idVenta = id;
            this.CantidadMaximaBarras = cantMaxBarras;
            this.CantidadMaximaColchonetas = cantMaxColchonetas;
            this.CantidadMaximaMancuernas = cantMaxColchonetas;
            this.listaBarras = new List<Barra>();
            this.listaMancuernas = new List<Mancuerna>();
            this.listaColchonetas = new List<Colchoneta>();

        }

        public virtual int ValidarCantMax(int cant)
        {
            int validado = 0;

            //si puede convertirlo lo retorna como numero
            if (int.TryParse(cant.ToString(), out validado) && (cant > 0 && cant <= 20))
            {
                return validado;
            }
            else
            {
                throw new CantMaxElementosInvalidaException();
            }


        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"ID DE LA VENTA: {this.idVenta}\n");
            sb.AppendFormat($"Cantidad de barras a vender: {this.listaBarras.Count}\n");
            sb.AppendFormat($"Cantidad de mancuernas a vender: {this.listaBarras.Count}\n");
            sb.AppendFormat($"Cantidad de colchonetas a vender: {this.listaBarras.Count}\n");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool Guardar(ElementosGimnasio elementos)
        {
            Texto t = new Texto();
            return t.Guardar("Venta.txt", elementos.ToString());
        }

        public static ElementosGimnasio operator +(ElementosGimnasio elementos, Barra barra)
        {

            if (elementos.listaBarras.Count < elementos.cantMaxBarras)
            {
                elementos.listaBarras.Add(barra);           
            }

            return elementos;

        }

        public static ElementosGimnasio operator +(ElementosGimnasio elementos, Mancuerna mancuerna)
        {

            if (elementos.listaMancuernas.Count < elementos.cantMaxMancuernas)
            {
                elementos.listaMancuernas.Add(mancuerna);
             
            }

            return elementos;
        }


        public static ElementosGimnasio operator +(ElementosGimnasio elementos, Colchoneta col)
        {

            if (elementos.listaColchonetas.Count < elementos.cantMaxColchonetas)
            {
                elementos.listaColchonetas.Add(col);
              
            }

            return elementos;
        }

        public static ElementosGimnasio operator -(ElementosGimnasio elementos, Colchoneta col)
        {

            if(!elementos.listaColchonetas.Contains(col))
            {
                elementos.listaColchonetas.Remove(col);
            }

            return elementos;
        }
        public static ElementosGimnasio operator -(ElementosGimnasio elementos, Barra barra)
        {

            if (!elementos.listaBarras.Contains(barra))
            {
                elementos.listaBarras.Remove(barra);
            }

            return elementos;
        }
        public static ElementosGimnasio operator -(ElementosGimnasio elementos, Mancuerna mancuerna)
        {

            if (!elementos.listaMancuernas.Contains(mancuerna))
            {
                elementos.listaMancuernas.Remove(mancuerna);
            }

            return elementos;
        }


    }


}
