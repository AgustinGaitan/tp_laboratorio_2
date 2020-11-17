﻿using System;
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
                Barra barraUno = new Barra();
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
                Mancuerna barraUno = new Mancuerna();
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
                Venta barraUno = new Venta();
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CantMaxElementosInvalidaException));
            }

        }
    }
}
