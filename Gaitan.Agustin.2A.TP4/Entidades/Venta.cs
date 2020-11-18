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
    //archivos;//
    //base de datos;//
    //metodo de extension;//
    //hilos;
    //excepciones;//
    //test unitarios;//
    //delegados y eventos


    public class Venta
    {
      
        private int cantMaxElementos;
        //private int cantMaxBarras;
        //private int cantMaxMancuernas;
        //private int cantMaxColchonetas;
        //private List<Barra> listaBarras;
        //private List<Mancuerna> listaMancuernas;
        //private List<Colchoneta> listaColchonetas;
       private List<ElementosGimnasio> listaTotal;

        public List<ElementosGimnasio> ListaTotal
        {
            get
            {
                return this.listaTotal;
            }
        }
        //public List<Barra> ListaBarras
        //{
        //    get
        //    {
        //        return this.listaBarras;
        //    }
        //}
        //public List<Mancuerna> ListaMancuernas
        //{
        //    get
        //    {
        //        return this.listaMancuernas;
        //    }
        //}
        //public List<Colchoneta> ListaColchonetas
        //{
        //    get
        //    {
        //        return this.listaColchonetas;
        //    }
        //}

        //public int CantidadMaximaMancuernas
        //{
        //    get
        //    {
        //        return this.cantMaxMancuernas;
        //    }
        //    set
        //    {
        //        this.cantMaxMancuernas = this.ValidarCantMax(value);
        //    }
        //}

        //public int CantidadMaximaBarras
        //{
        //    get
        //    {
        //        return this.cantMaxBarras;
        //    }
        //    set
        //    {
        //        this.cantMaxBarras = this.ValidarCantMax(value);
        //    }
        //}


        //public int CantidadMaximaColchonetas
        //{
        //    get
        //    {
        //        return this.cantMaxColchonetas;
        //    }
        //    set
        //    {
        //        this.cantMaxColchonetas = this.ValidarCantMax(value);
        //    }
        //}

        public Venta()
        {
            
        }


        public Venta(int cantMaxElementos)
        {
            this.cantMaxElementos = cantMaxElementos;
            //this.CantidadMaximaBarras = cantMaxBarras;
            //this.CantidadMaximaColchonetas = cantMaxColchonetas;
            //this.CantidadMaximaMancuernas = cantMaxColchonetas;
            //this.listaBarras = new List<Barra>();
            //this.listaMancuernas = new List<Mancuerna>();
            //this.listaColchonetas = new List<Colchoneta>();
            this.listaTotal = new List<ElementosGimnasio>();

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

        public static bool Guardar(Venta venta)
        {
            Texto t = new Texto();
            return t.Guardar("ventas.txt", venta.ToString());
        }

        public static string Leer()
        {
            Texto nuevoTexto = new Texto();
            nuevoTexto.Leer("ventas.txt", out string datos);

            return datos;
        }

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("VENTA ");
            sb.AppendLine("LISTADO DE PRODUCTOS: ");

            foreach(ElementosGimnasio item in this.ListaTotal)
            {
                sb.Append(item.ToString());
            }
            sb.AppendLine("------------------------------------------");

            return sb.ToString();
        }


        public static bool GuardarSer(Venta venta)
        {
            Xml<Venta> u = new Xml<Venta>();

            return u.Guardar("venta.xml", venta);
        }

        public static Venta LeerSerializado()
        {
            Xml<Venta> u = new Xml<Venta>();
            u.Leer("venta.xml", out Venta ventaXml); //out retorna el los datos leídos
            return ventaXml;
        }

        public static Venta operator +(Venta venta, ElementosGimnasio elemento)
        {
            if(venta.ListaTotal.Count < venta.cantMaxElementos)
            {
                venta.ListaTotal.Add(elemento);
            }
           

            return venta;
        }

        public static Venta operator -(Venta venta, ElementosGimnasio elemento)
        {
           
                venta.ListaTotal.Remove(elemento);
          
            return venta;
        }
       
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static Venta operator +(Venta venta, List<ElementosGimnasio> elemento)
        {

           
            for(int indice = 0; indice < elemento.Count; indice++)
            {
                venta.listaTotal.Add(elemento[indice]);
            }
            
            return venta;
        }

        public static Venta operator -(Venta venta, List<ElementosGimnasio> elemento)
        {
            for (int indice = 0; indice < elemento.Count; indice++)
            {
                venta.listaTotal.Remove(elemento[indice]);
            }

            return venta;
        }

    }


}
