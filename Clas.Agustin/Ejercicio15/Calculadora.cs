using System;
namespace Ejercicio15
{
    public class Calculadora
    {
        public static double Calcular(double a, double b, char operador)
        {
            double resultado=0;

            if (operador == '+')
            {
                resultado = a + b;
            }
            else if (operador == '-')
            {
                resultado = a - b;
            }
            else if (operador == '*')
            {
                resultado = a * b;
            }
            else if (operador == '/')
            {
                if (Calculadora.Validar(b))
                {
                    resultado = (a / b);
                }
                else
                {
                    Console.WriteLine("No es posible dividir por cero;");
                }
            }

            return resultado;
        }

        private static bool Validar(double numero)
        {
            bool validacion = false;

            if(numero != 0)
            {
                validacion = true;
            }

            return validacion;
        }
    }
}
