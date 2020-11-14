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


    public class Gimnasio : Club ,ISerializar, IDeserializar<Gimnasio>
    {
        

        public Gimnasio()
        {
        }

        public Gimnasio(int cantAgua, int cantPowerade, int cantBarrasEnergeticas, string nombre)
            :base(cantAgua,cantPowerade,cantBarrasEnergeticas,nombre)
        {

        }

        bool ISerializar.Xml()
        {
            bool rta = true;

            

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("gimnasioXml.xml", System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Gimnasio));

                    ser.Serialize(escritor, this);
                }

            }
            catch (Exception)
            {
                rta = false;

            }

            return rta;
        }

        bool IDeserializar<Gimnasio>.Xml(out Gimnasio gym)
        {
            bool rta = true;
            string path = typeof(Gimnasio).Name;

            try
            {
                using (XmlTextReader lector = new XmlTextReader(path + ".xml"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Gimnasio));

                    gym = (Gimnasio)ser.Deserialize(lector);

                }

            }
            catch (Exception)
            {
                rta = false;
                gym = new Gimnasio();

            }

            return rta;

        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
              
            
            sb.AppendFormat("PARTE DEL CLUB: {0}\n", this.Nombre);
            sb.Append(base.MostrarDatos());

            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }

    }
}
