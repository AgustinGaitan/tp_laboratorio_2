using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Excepciones;
using System.Xml;

namespace Archivos
{
    public class Xml<T>
    {

        public bool Guardar(string archivo, T datos)
        {
            bool rta = false;
            try
            {
                
                using (XmlTextWriter writter = new XmlTextWriter(archivo, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializadorxml = new XmlSerializer(typeof(T));

                    serializadorxml.Serialize(writter, datos);
                    rta = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return rta;
        }



        public bool Leer(string archivo, out T datos)
        {
            bool rta = false;
            datos = default(T);
            try
            {
                
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer serializadorxml = new XmlSerializer(typeof(T));

                    datos = (T)serializadorxml.Deserialize(reader);
                    rta = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return rta;
        }






    }
}
