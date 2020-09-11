using System;
using System.Threading;

namespace Entidades
{
    class Numero
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
            string numeroConvertido = "";

            if(EsBinario(binario))
            {

                numeroConvertido = Convert.ToInt32(binario, 2).ToString();

            }
            else
            {
                Console.WriteLine("Valor invalido.");
            }
            return numeroConvertido;
        }

        public string DecimalBinario(double numero)
        {
            string retorno = "";
            string numeroString;
            int numeroVerificacion;
            int numeroTransformado;

            numeroString = numero.ToString();  // lo paso a string para verificar si es un num.

                if(int.TryParse(numeroString,out numeroVerificacion) //Verificacion, al igual que el otro metodo
                {
                    numeroTransformado = Convert.ToInt32(numeroString, 2);

                    retorno = numeroTransformado.ToString();
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
                

            return retorno;
        }

        public string DecimalBinario(string numero)
        {
            string retorno = "";
            int numeroBinarioVerificacion;
            int numeroTransformado;
            
            if(int.TryParse(numero, out numeroBinarioVerificacion))
            {
                numeroTransformado = Convert.ToInt32(numero, 2);

                retorno = numeroTransformado.ToString();
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }

            return retorno;
        } 

        private bool EsBinario(string binario)
        {
            bool retorno = false;
            int acumCaracteres = 0;
            int caracteresValidos = 0;

            for(int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '1' || binario[i] != '0')
                {
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
            int numeroValidado;

            if(int.TryParse(strNumero, out numeroValidado))
            {
                this.numero = numeroValidado;

            }

        }

        #endregion 




        private double ValidarNumero(string strNumero)
        {
            double valor = 0;

            int acumCaracteres = 0;
            int caracteresValidos = 0;

            for (int i = 0; i < strNumero.Length; i++)
            {
               if (strNumero[i] == '0' ||
                    strNumero[i] == '1' ||
                    strNumero[i] == '2' ||
                    strNumero[i] == '3' ||
                    strNumero[i] == '4' ||
                    strNumero[i] == '5' ||
                    strNumero[i] == '6' ||
                    strNumero[i] == '7' ||
                    strNumero[i] == '8' ||
                    strNumero[i] == '9' ||
                    strNumero[i] == '.')  
               
                {
                    acumCaracteres += caracteresValidos;
                } 


            }

            if (caracteresValidos == strNumero.Length)
            {
                valor = double.Parse(strNumero);
            }
          
            return valor;

        }
    }
}
