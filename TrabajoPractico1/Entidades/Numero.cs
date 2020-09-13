using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace Entidades
{
    public class Numero
    {

        private double numero; //atributo


        /// <summary>
        /// Setea un numero en el atributo de la clase.
        /// </summary>
        public string SetNumero  //propiedad
        {
            
          
            set
            {
                this.numero = ValidarNumero(value);

            }

        }

        /// <summary>
        /// Pasa un numero binario a decimal.
        /// </summary>
        /// <param name="binario"> Numero binario </param>
        /// <returns></returns>

        public string BinarioDecimal(string binario)
        {
            int binANumero;

            if(EsBinario(binario))
            {

                    binANumero =  Convert.ToInt32(binario, 2);
                

                return binANumero.ToString();

            }
            else
            {
                return "Valor inválido.";
            }
           
        }

        /// <summary>
        /// Pasa un numero decimal a binario.
        /// </summary>
        /// <param name="numero">numero decimal a transformar</param>
        /// <returns>El numero transformado </returns>
        public string DecimalBinario(double numero)
        {
           
            string numeroString;
            int numeroVerificacion;
           
                 numeroString = numero.ToString(); // lo paso a string para verificar si es un num.
                if(int.TryParse(numeroString, out numeroVerificacion))
                {
                    if (numeroVerificacion >= 0) //Verificacion, al igual que el otro metodo
                    {

                        return Convert.ToString(numeroVerificacion, 2);
                    }
                    else
                    {
                        return "Valor inválido.";
                    }
                }
                else
                {
                    return "Valor inválido.";
                }
               
                

            //return retorno;
        }

        /// <summary>
        /// Pasa un numero de decimal a binario
        /// </summary>
        /// <param name="numero"> numero a transformar</param>
        /// <returns>Numero transformado</returns>
        public string DecimalBinario(string numero)
        {
           
            int numeroBinarioVerificacion;
            int numeroTransformado;
            
            if(int.TryParse(numero, out numeroBinarioVerificacion))
            {
                if(numeroBinarioVerificacion >= 0)
                {
                    numeroTransformado = Convert.ToInt32(numero, 2);

                    return numeroTransformado.ToString();
                }
                else
                {
                    return "Valor inválido.";
                }
            }
            else
            {
                return "Valor inválido.";
            }

            
        } 

        /// <summary>
        /// Valida si es binario
        /// </summary>
        /// <param name="binario">Numero a validar </param>
        /// <returns>true si es binario, false si no</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = false;
            int acumCaracteres = 0;
            int caracteresValidos = 0;

            for(int i = 0; i < binario.Length; i++)
            {
                if(binario[i] == '1' || binario[i] == '0')
                {
                    caracteresValidos++;
                    acumCaracteres += caracteresValidos; 
                }


            }

            if (caracteresValidos == binario.Length)
            {
                retorno = true;
            }

            return retorno;
        }

        #region Constructores

        /// <summary>
        /// Constructor 
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor con parametro
        /// </summary>
        /// <param name="numero">parametro tipo double a asignar</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor con parametro
        /// </summary>
        /// <param name="numero">parametro tipo string a asignar</param>
        public Numero(string strNumero)
        {


            this.SetNumero = strNumero;
        }

        #endregion 
        /// <summary>
        /// sobrecarga del operador -
        /// </summary>
        /// <param name="n1">numero1</param>
        /// <param name="n2">numero 2</param>
        /// <returns>resultado entre dos variables Tipo Numero </returns>
        public static double operator - (Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        /// <summary>
        /// sobrecarga del operador *
        /// </summary>
        /// <param name="n1">numero1</param>
        /// <param name="n2">numero 2</param>
        /// <returns>resultado entre dos variables Tipo Numero </returns>
        public static double operator * (Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }

        /// <summary>
        /// sobrecarga del operador /
        /// </summary>
        /// <param name="n1">numero1</param>
        /// <param name="n2">numero 2</param>
        /// <returns>resultado entre dos variables Tipo Numero </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;

            if (n2.numero != 0)
            {
                resultado = n1.numero / n2.numero;

            }
            else
            {
                resultado = double.MinValue;
            }

            
            return resultado;
        }
        /// <summary>
        /// sobrecarga del operador +
        /// </summary>
        /// <param name="n1">numero1</param>
        /// <param name="n2">numero 2</param>
        /// <returns>resultado entre dos variables Tipo Numero </returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado; 
        }

        /// <summary>
        /// Valida si es un numero o no
        /// </summary>
        /// <param name="strNumero">string a validar</param>
        /// <returns>numero validado</returns>
        private double ValidarNumero(string strNumero)
        {
            double resultante = 0;

            if(double.TryParse(strNumero, out resultante))
            {
                return resultante;
            }
            else
            {
                return resultante;
            }

        }
    }
}
