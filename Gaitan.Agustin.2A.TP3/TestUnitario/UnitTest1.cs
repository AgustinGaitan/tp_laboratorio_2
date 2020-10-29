using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using Excepciones;
using ClasesAbstractas;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            public void Lista_Alumnos_Correcta()
            {
                Universidad u = new Universidad();
                Assert.IsNotNull(u.Alumnos);
            }

            /// <summary>
            /// Valida que el alumno no se repita
            /// </summary>
            [TestMethod]
            public void Alumno_Repetido()
            {
                try
                {
                    Universidad uni = new Universidad();

                    Alumno a1 = new Alumno(1, "Nicolas", "Tuchtfeldt", "99999999", Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD);
                    Alumno a2 = new Alumno(2, "Nicolas", "Tuchtfeldt", "99999999", Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD);

                    uni += a1;
                    uni += a2;

                    Assert.Fail("El alumno esta repetido.");
                }
                catch (Exception e)
                {
                    Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
                }
            }


            /// <summary>
            /// Comprueba los rangos de DNI para Argentinos
            /// </summary>
            [TestMethod]
            public void DNI_Validos_Argentino()
            {
                string dniUno = "1";
                string dniDos = new Random().Next(1, 89999999).ToString();
                string dniTres = "89999999";


                Alumno alumnoUno = new Alumno(1, "Agustin", "Gaitan", dniUno, Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
                Assert.AreEqual(Convert.ToInt32(alumnoUno.DNI), Convert.ToInt32(dniUno));

                Alumno alumnoDos = new Alumno(2, "Juan", "Blanco", dniDos, Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
                Assert.AreEqual(Convert.ToInt32(alumnoDos.DNI), Convert.ToInt32(dniDos));

                Alumno alumnoTres = new Alumno(3, "Silvio", "Rivero", dniTres, Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
                Assert.AreEqual(Convert.ToInt32(alumnoTres.DNI), Convert.ToInt32(dniTres));

            }

            /// <summary>
            /// Valida que el DNI en formato texto NO pueda tener letras ni comas
            /// </summary>
            [TestMethod]
            public void DNI_Invalido()
            {
                string dniConComa = "30.999,999";
                string dniConTexto = "30a00123";

                try
                {
                    Alumno personaPrimero = new Alumno(1, "Nicolas", "Viegas", dniConComa, Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
                    Assert.Fail("Sin excepción para DNI inválido: {0}.", dniConComa);
                }
                catch (Exception e)
                {
                    Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
                }

                try
                {
                    Alumno personaPrimero = new Alumno(1, "Jorge", "Jorgelín", dniConComa, Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
                    Assert.Fail("Sin excepción para DNI inválido: {0}.", dniConTexto);
                }
                catch (Exception e)
                {
                    Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
                }
            }
        
    }
}
