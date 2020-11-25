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
    //delegados y eventos//


    public class Venta
    {
      
        private int cantMaxElementos;
       private List<ElementosGimnasio> listaTotal;

        /// <summary>
        /// Propiedad s/l que retorna la lista total de elementos
        /// </summary>
        public List<ElementosGimnasio> ListaTotal
        {
            get
            {
                return this.listaTotal;
            }
        }
    
        /// <summary>
        /// constructor por default
        /// </summary>
        public Venta()
        {
            
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="cantMaxElementos">Cantidad maxima de elementos</param>
        public Venta(int cantMaxElementos)
        {
            this.cantMaxElementos = cantMaxElementos;
 
            this.listaTotal = new List<ElementosGimnasio>();

        }


        /// <summary>
        /// Muestra los datos
        /// </summary>
        /// <returns>Un string con los datos</returns>
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


        /// <summary>
        /// Metodo estatico que guarda un archivo en .xml
        /// </summary>
        /// <param name="venta">venta a guardar</param>
        /// <returns></returns>
        public static bool GuardarSer(Venta venta)
        {
            Xml<Venta> u = new Xml<Venta>();

            return u.Guardar("venta.xml", venta);
        }

        /// <summary>
        /// Metodo estatico que lee un archivo .xml
        /// </summary>
        /// <returns></returns>
        public static Venta LeerSerializado()
        {
            Xml<Venta> u = new Xml<Venta>();
            u.Leer("venta.xml", out Venta ventaXml); //out retorna el los datos leídos
            return ventaXml;
        }

        /// <summary>
        /// sobrecarga del operador +
        /// </summary>
        /// <param name="venta">venta a ser sumada</param>
        /// <param name="elemento">elemento a ser sumado</param>
        /// <returns>la venta ya sumada/returns>
        public static Venta operator +(Venta venta, ElementosGimnasio elemento)
        {
            if(venta.ListaTotal.Count < venta.cantMaxElementos)
            {
                venta.ListaTotal.Add(elemento);
            }
           

            return venta;
        }

        /// <summary>
        /// sobrecarga del operador -
        /// </summary>
        /// <param name="venta">venta a ser restado</param>
        /// <param name="elemento">elemento a ser restado</param>
        /// <returns>la venta ya restada/returns>
        public static Venta operator -(Venta venta, ElementosGimnasio elemento)
        {
           
                venta.ListaTotal.Remove(elemento);
          
            return venta;
        }
       
        /// <summary>
        /// Sobreescritura del metodo ToString
        /// </summary>
        /// <returns>Cadena con los datos</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="venta">Venta a ser sumada</param>
        /// <param name="elemento">Lista a ser sumada</param>
        /// <returns>Venta sumada</returns>
        public static Venta operator +(Venta venta, List<ElementosGimnasio> elemento)
        {

           
            for(int indice = 0; indice < elemento.Count; indice++)
            {
                venta.listaTotal.Add(elemento[indice]);
            }
            
            return venta;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="venta">Venta a ser restada</param>
        /// <param name="elemento">Lista a restar</param>
        /// <returns>Venta restada</returns>
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
