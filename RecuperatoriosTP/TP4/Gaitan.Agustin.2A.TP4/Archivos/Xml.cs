using Excepciones;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    /// <summary>
    /// Clase generica
    /// </summary>
    /// <typeparam name="T">tipo de dato a pasarle</typeparam>
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Método que guarda datos en un archivo .txt
        /// </summary>
        /// <param name="archivo">Ruta del archivo</param>
        /// <param name="datos">Datos a guardar</param>
        /// <returns>True si se pudo guardar/False si no</returns>
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
            catch (Exception)
            {
                throw new ArchivosException();
            }
            return rta;
        }


        /// <summary>
        /// Método que lee datos de un archivo
        /// </summary>
        /// <param name="archivo">Ruta del archivo</param>
        /// <param name="datos">Datos leidos</param>
        /// <returns>True si se pudo leer, False si no</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool rta = false;
            datos = default(T); //se le asigna en caso de que haya excepcion
            try
            {

                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer serializadorxml = new XmlSerializer(typeof(T));

                    datos = (T)serializadorxml.Deserialize(reader);
                    rta = true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException();
            }
            return rta;
        }

    }
}
