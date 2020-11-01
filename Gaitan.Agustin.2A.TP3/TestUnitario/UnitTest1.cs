using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using Excepciones;
using EntidadesAbstractas;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            
          
            public void ListaAlumnosCorrecta()
            {
                Universidad u = new Universidad();
                Assert.IsNotNull(u.Alumnos);
            }

        [TestMethod]
       
        public void VerificarNacionalidad()
        {
            try
            {
                Alumno alumno1 = new Alumno(1, "Jorge", "Parrilla", "90005000", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
                Alumno alumno2 = new Alumno(2, "Lucas", "Fernandez", "500", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
            


        }


        /// <summary>
        /// Valida que el DNI en formato texto NO pueda tener letras ni comas
        /// </summary>
        [TestMethod]
       
        public void DNIInvalido()
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

        /// <summary>
        /// Valida que el alumno no se repita
        /// </summary>
        [TestMethod]
    
        public void AlumnoRepetido()
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


            

        
    }
}
