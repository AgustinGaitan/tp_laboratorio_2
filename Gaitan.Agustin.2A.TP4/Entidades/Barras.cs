using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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


    public class Barras : ElementosGimnasio ,ISerializar, IDeserializar<Barras>
    {
        

        public Barras()
        {

        }

        public Barras(string nombre, int cantMaxima)
            : base(nombre, cantMaxima)
        {

        }

        bool ISerializar.Xml()
        {
            bool rta = true;
          
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("\\BarrasXml.xml", System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Barras));

                    ser.Serialize(escritor, this);
                }

            }
            catch (Exception)
            {
                rta = false;

            }

            return rta;
        }

        bool IDeserializar<Barras>.Xml(out Barras gym)
        {
            bool rta = true;
            string path = typeof(Barras).Name;

            try
            {
                using (XmlTextReader lector = new XmlTextReader(path + ".xml"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Barras));

                    gym = (Barras)ser.Deserialize(lector);

                }

            }
            catch (Exception)
            {
                rta = false;
                gym = new Barras();

            }

            return rta;

        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
              
            
            sb.AppendFormat($"Cantidad de {GetType(Barras).Name} : {this.c);
            sb.Append(base.MostrarDatos());

            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }

    }
}
