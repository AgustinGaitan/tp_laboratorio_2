namespace Archivos
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Método que guarda datos en un archivo
        /// </summary>
        /// <param name="archivo">Ruta del archivo</param>
        /// <param name="datos">Datos a guardar</param>
        /// <returns>True si se pudo guardar, False si no</returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// Método que lee datos de un archivo
        /// </summary>
        /// <param name="archivo">Ruta del archivo</param>
        /// <param name="datos">Datos leidos</param>
        /// <returns>True si se pudo leer, False si no</returns>
        bool Leer(string archivo, out T datos);
    }
}
