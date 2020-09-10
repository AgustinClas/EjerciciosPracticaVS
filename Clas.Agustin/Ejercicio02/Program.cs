using System;

namespace Ejercicio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double numero;
            string numeroStr;

            Console.WriteLine("Ingrese un numero: ");
            numeroStr = Console.ReadLine();
            numero = double.Parse(numeroStr);
            while (numero < 1)
            {
               Console.WriteLine("Error! Ingresar numero: ");
               numeroStr = Console.ReadLine();
               numero = int.Parse(numeroStr);
            }

            Console.WriteLine($"El cuadrado del numero ingresado es: {Math.Pow(numero, 2)}");
            Console.WriteLine($"El cubo del numero ingresado es: {Math.Pow(numero, 3)}");

            Console.ReadKey(true);
        }
    }
}
