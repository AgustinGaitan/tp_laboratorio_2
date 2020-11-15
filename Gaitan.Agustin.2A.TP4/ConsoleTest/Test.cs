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
            ElementosGimnasio ventaUno = new ElementosGimnasio(2, 2, 2, 1);
            Barra barraUno = new Barra(100, 2, 1);
            Barra barraDos = new Barra(100, 2, 1);
            Barra barraTres = new Barra(100, 2, 1);
            Barra barraCuatro = new Barra(100, 2, 2);
            Mancuerna mancuernaUno = new Mancuerna(150, 5, 1);
            Mancuerna mancuernaDos = new Mancuerna(150, 5, 1);
            Mancuerna mancuernaTres = new Mancuerna(150, 5, 2);
            Colchoneta colchonetaUno = new Colchoneta(50, EColor.Azul, 1);
            Colchoneta colchonetaDos = new Colchoneta(50, EColor.Rojo, 1);
            Colchoneta colchonetaTres = new Colchoneta(50, EColor.Verde, 2);

            ventaUno += barraUno;
            ventaUno += barraDos;
            ventaUno += barraTres;
            ventaUno += barraCuatro;

            Console.WriteLine(ventaUno.ToString());


            Console.ReadLine();
        }
    }
}
