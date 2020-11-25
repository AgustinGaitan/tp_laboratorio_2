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
            //creo los objetos
                Venta ventaUno = new Venta(10);
                Venta ventaDos = new Venta(10);
                Venta ventaTres = new Venta(10);
                Barra barraUno = new Barra(2);
                Barra barraDos = new Barra(3);
                Barra barraTres = new Barra(7);
                Barra barraCuatro = new Barra(2);
                Barra barraCinco = new Barra(1);
                Mancuerna mancuernaUno = new Mancuerna(5);
                Mancuerna mancuernaDos = new Mancuerna(10);
                Mancuerna mancuernaTres = new Mancuerna(2);
                Colchoneta colchonetaUno = new Colchoneta("azul");
                Colchoneta colchonetaDos = new Colchoneta("verde");
                Colchoneta colchonetaTres = new Colchoneta("rojo");

            //añado los elementos a la venta
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
                ventaDos += colchonetaTres;
                ventaDos += colchonetaUno;
                ventaUno -= colchonetaUno;
                ventaTres += new Mancuerna(2);

            //Muestro los datos
                Console.WriteLine(ventaUno.ToString());
                Console.WriteLine(ventaDos.ToString());
                Console.WriteLine(ventaTres.ToString());

            //Pruebo guardar los datos
                if (ventaUno.Guardar() && ventaDos.Guardar() && ventaTres.Guardar())
                {

                    Console.WriteLine("Ventas guardadas.\n\n");
         
                }

                Console.WriteLine("************************************************");
                Console.WriteLine("Lectura de archivo:");
                Console.WriteLine(ventaUno.Leer()); //Pruebo leerlos


            Console.ReadLine();
        }
    }
}
