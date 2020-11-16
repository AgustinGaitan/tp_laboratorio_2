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
                Barra barraUno = new Barra(500, 600, 1);
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(LongitudInvalidaException));
            }
            
        }

        [TestMethod]
        public void Test_PesoInvalido()
        {
            try
            {
                Mancuerna barraUno = new Mancuerna(500, 400, 1);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(PesoInvalidoException));
            }

        }

        [TestMethod]
        public void Test_ElementosMaxInvalido()
        {
            try
            {
                ElementosGimnasio barraUno = new ElementosGimnasio(100, 5, 6, 1);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CantMaxElementosInvalidaException));
            }

        }
    }
}
