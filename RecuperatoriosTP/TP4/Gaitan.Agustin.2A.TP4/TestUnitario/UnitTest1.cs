using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using Archivos;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_MeterListaElementos()
        {
           
                Venta venta = new Venta(1);
                ElementosGimnasio elemento = new ElementosGimnasio(5);
                
                venta += elemento;
                int count = venta.ListaTotal.Count;
                Assert.AreEqual(1, count);
       
            
        }

        [TestMethod]
        public void Test_SacarListaElementos()
        {

            Venta venta = new Venta(2);
            ElementosGimnasio elemento = new ElementosGimnasio(5);

            venta += elemento;
            venta -= elemento;
            int count = venta.ListaTotal.Count;
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void Test_ArchivoError()
        {
            Texto txt = new Texto();
            string dato;

            txt.Leer("asdasd.txt", out dato );


        }
    }
}
