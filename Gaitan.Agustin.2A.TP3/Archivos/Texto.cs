using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool rta = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, true))
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


        public bool Leer(string archivo, out string datos)
        {
            bool rta = false;

            datos = null;

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
