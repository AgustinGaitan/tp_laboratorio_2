using Excepciones;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Archivos;

namespace Entidades
{


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


    public class Venta
    {
        protected int idVenta;
        protected int precio;
        private int cantMaxBarras;
        private int cantMaxMancuernas;
        private int cantMaxColchonetas;
        private List<Barra> listaBarras;
        private List<Mancuerna> listaMancuernas;
        private List<Colchoneta> listaColchonetas;
        private List<Venta> listaTotal;

        public List<Venta> ListaTotal
        {
            get
            {
                return this.listaTotal;
            }
        }
        public List<Barra> ListaBarras
        {
            get
            {
                return this.listaBarras;
            }
        }
        public List<Mancuerna> ListaMancuernas
        {
            get
            {
                return this.listaMancuernas;
            }
        }
        public List<Colchoneta> ListaColchonetas
        {
            get
            {
                return this.listaColchonetas;
            }
        }

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

        public Venta()
        {
            
        }


        public Venta(int cantMaxMancuernas, int cantMaxBarras, int cantMaxColchonetas,int id)
        {
            this.idVenta = id;
            this.CantidadMaximaBarras = cantMaxBarras;
            this.CantidadMaximaColchonetas = cantMaxColchonetas;
            this.CantidadMaximaMancuernas = cantMaxColchonetas;
            this.listaBarras = new List<Barra>();
            this.listaMancuernas = new List<Mancuerna>();
            this.listaColchonetas = new List<Colchoneta>();
            this.listaTotal = new List<Venta>();

        }

        public int ValidarCantMax(int cant)
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
            sb.AppendFormat($"ID DE LA VENTA: {this.idVenta}\n\n");
            sb.AppendFormat($"Cantidad de barras a vender: {this.listaBarras.Count}\n");
            sb.AppendFormat($"Cantidad de mancuernas a vender: {this.listaMancuernas.Count}\n");
            sb.AppendFormat($"Cantidad de colchonetas a vender: {this.listaColchonetas.Count}\n\n");
            sb.AppendLine("LISTADO DE PRODUCTOS: ");

            foreach(Venta item in this.ListaTotal)
            {
                sb.Append(item.ToString());
            }
            sb.AppendLine("------------------------------------------");

            return sb.ToString();
        }


        

        public static bool Guardar(Venta elementos)
        {
            Texto t = new Texto();
            return t.Guardar("Venta.txt", elementos.ToString());
        }

        public static string Leer()   
        {
            Texto nuevoTexto = new Texto();
            nuevoTexto.Leer("Venta.txt", out string datos);

            return datos;
        }
        public static Venta operator +(Venta elementos, Barra barra)
        {

            if (elementos.listaBarras.Count < elementos.cantMaxBarras)
            {
                elementos.listaTotal.Add(barra);
                elementos.listaBarras.Add(barra);           
            }

            return elementos;

        }

        public static Venta operator +(Venta elementos, Mancuerna mancuerna)
        {

            if (elementos.listaMancuernas.Count < elementos.cantMaxMancuernas)
            {
                elementos.listaTotal.Add(mancuerna);
                elementos.listaMancuernas.Add(mancuerna);
             
            }

            return elementos;
        }


        public static Venta operator +(Venta elementos, Colchoneta col)
        {

            if (elementos.listaColchonetas.Count < elementos.cantMaxColchonetas)
            {
                elementos.listaTotal.Add(col);
                elementos.listaColchonetas.Add(col);
              
            }

            return elementos;
        }

        public static Venta operator -(Venta elementos, Colchoneta col)
        {

            if(elementos.listaColchonetas.Contains(col))
            {
                elementos.listaTotal.Remove(col);
                elementos.listaColchonetas.Remove(col);
            }

            return elementos;
        }
        public static Venta operator -(Venta elementos, Barra barra)
        {

            if (elementos.listaBarras.Contains(barra))
            {
                elementos.listaTotal.Remove(barra);
                elementos.listaBarras.Remove(barra);
            }

            return elementos;
        }
        public static Venta operator -(Venta elementos, Mancuerna mancuerna)
        {

            if (elementos.listaMancuernas.Contains(mancuerna))
            {
                elementos.listaTotal.Add(mancuerna);
                elementos.listaMancuernas.Remove(mancuerna);
            }

            return elementos;
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }


}
