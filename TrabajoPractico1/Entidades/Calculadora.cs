using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida al operador
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Operador, en caso de no serlo, retorna "+"</returns>
       private static string ValidarOperador(char operador)
       {     

            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador.ToString();
            }

            return '+'.ToString();
       }

        /// <summary>
        /// Realiza la operacion
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operador </param>
        /// <returns>Resultado</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            if(operador == "+")
            {
                resultado = num1 + num2;
            }
            else if( operador == "-")
            {
                resultado = num1 - num2;
            }
            else if(operador == "/")
            {
                resultado = num1 / num2;

            }
            else if(operador == "*")
            {
                resultado = num1 * num2;
            }

            return resultado;
        }

    }
}
