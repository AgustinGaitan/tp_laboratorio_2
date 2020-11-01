using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    /// <summary>
    /// Clase publica
    /// </summary>
    public class Texto : IArchivo<string>
    {
       /// <summary>
       /// Método que guarda datos en un archivo .txt
       /// </summary>
       /// <param name="archivo">Ruta del archivo</param>
       /// <param name="datos">Datos a guardar</param>
       /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            bool rta = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, true))  //Append en true
                {
                    sw.WriteLine(datos);


                    rta = true;
                }
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }
           

            return rta;
        }

        /// <summary>
        /// Método que lee archivos
        /// </summary>
        /// <param name="archivo">Ruta</param>
        /// <param name="datos">Datos a leer</param>
        /// <returns>True si se pudo, False si no.</returns>

        public bool Leer(string archivo, out string datos)
        {
            bool rta = false;

            datos = null; //se le asigna en caso de que haya excepcion

            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    datos = sr.ReadToEnd();
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
