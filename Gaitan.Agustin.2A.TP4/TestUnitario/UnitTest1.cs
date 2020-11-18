using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_LongitudInvalida()
        {
            try
            {
                Barra barraUno = new Barra(500);
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(FilaVaciaException));
            }
            
        }

        [TestMethod]
        public void Test_PesoInvalido()
        {
            try
            {
                Mancuerna barraUno = new Mancuerna(900);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ProductoSinSeleccionarException));
            }

        }

        [TestMethod]
        public void Test_ElementosMaxInvalido()
        {
            try
            {
                //Venta barraUno = new Venta(522,674,125,1);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CantMaxElementosInvalidaException));
            }

        }
    }
}
