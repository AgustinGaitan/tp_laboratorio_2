using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using Archivos;

namespace ConsoleTest
{
    class Test
    {
        static void Main(string[] args)
        {
            try
            {
                Venta ventaUno = new Venta(2, 2, 2, 1);
                Venta ventaDos = new Venta(4, 4, 2, 2);
                Venta ventaTres = new Venta(1, 1, 1, 3);
                Barra barraUno = new Barra(ELongitud.Chica);
                Barra barraDos = new Barra(ELongitud.Larga);
                Barra barraTres = new Barra(ELongitud.Mediana);
                Barra barraCuatro = new Barra(ELongitud.Larga);
                Barra barraCinco = new Barra(ELongitud.Larga);
                Mancuerna mancuernaUno = new Mancuerna(EPeso.Liviana);
                Mancuerna mancuernaDos = new Mancuerna(EPeso.Media);
                Mancuerna mancuernaTres = new Mancuerna(EPeso.Pesada);
                Colchoneta colchonetaUno = new Colchoneta(EColor.Azul);
                Colchoneta colchonetaDos = new Colchoneta(EColor.Verde);
                Colchoneta colchonetaTres = new Colchoneta(EColor.Violeta);


                ventaUno += barraUno;
                ventaUno += barraDos;
                ventaUno += barraTres;
                ventaUno += barraCuatro;
                ventaUno -= barraUno;
                ventaUno += mancuernaUno;
                ventaUno += mancuernaDos;
                ventaUno += mancuernaTres;
                ventaUno += colchonetaUno;
                ventaUno += colchonetaDos;
                ventaUno += colchonetaTres;
                ventaDos += barraCinco;
                ventaUno -= colchonetaUno;
                ventaTres += new Mancuerna(EPeso.Pesada);

                Console.WriteLine(ventaUno.ToString());
                Console.WriteLine(ventaDos.ToString());
                Console.WriteLine(ventaTres.ToString());

                if (Venta.Guardar(ventaUno) && Venta.Guardar(ventaDos) && Venta.Guardar(ventaTres))
                {

                    Console.WriteLine("Ventas guardadas.\n\n");
                }

                Console.WriteLine("************************************************");
                Console.WriteLine("Lectura de archivo:");
                //Console.WriteLine(Venta.Leer());


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }






            Console.ReadLine();
        }
    }
}
