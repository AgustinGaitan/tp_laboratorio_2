using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
       private static string ValidarOperador(char operador)
       {     

            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador.ToString();
            }

            return "+";
       }

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
