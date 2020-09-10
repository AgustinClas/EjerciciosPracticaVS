using System;

namespace Ejercicio15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string numeroUsuarioStr;
            double numeroA;
            double numeroB;
            char operador;
            double resultado;

            Console.WriteLine("Ingrese el primer numero");
            numeroUsuarioStr = Console.ReadLine();
            numeroA = double.Parse(numeroUsuarioStr);

            Console.WriteLine("Ingrese el segundo numero");
            numeroUsuarioStr = Console.ReadLine();
            numeroB = double.Parse(numeroUsuarioStr);

            Console.WriteLine("Ingrese el operador");
            operador = (char)Console.Read();

            Console.Write("\nEl resultado de la operacion es: ");
            resultado = Calculadora.Calcular(numeroA, numeroB, operador);

            Console.WriteLine(resultado);
        }
    }
}
