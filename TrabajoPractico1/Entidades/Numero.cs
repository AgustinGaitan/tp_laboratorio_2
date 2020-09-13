using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace Entidades
{
    public class Numero
    {

        private double numero; //atributo



        public string SetNumero  //propiedad
        {
            
          
            set
            {
                this.numero = ValidarNumero(value);

            }

        }


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

        public string DecimalBinario(double numero)
        {
           
            string numeroString;
            int numeroVerificacion;
           

            numeroString = numero.ToString(); // lo paso a string para verificar si es un num.

                if(int.TryParse(numeroString,out numeroVerificacion)) //Verificacion, al igual que el otro metodo
                {
                  
                    return Convert.ToString(numeroVerificacion,2);
                }
                else
                {
                    return  "Valor inválido.";
                }
                

            //return retorno;
        }

        public string DecimalBinario(string numero)
        {
           
            int numeroBinarioVerificacion;
            int numeroTransformado;
            
            if(int.TryParse(numero, out numeroBinarioVerificacion))
            {
                numeroTransformado = Convert.ToInt32(numero, 2);

                return numeroTransformado.ToString();
            }
            else
            {
                return "Valor inválido.";
            }

            
        } 

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

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {


            this.SetNumero = strNumero;
        }

        #endregion 

        public static double operator - (Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        public static double operator * (Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }
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

        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado; 
        }


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
