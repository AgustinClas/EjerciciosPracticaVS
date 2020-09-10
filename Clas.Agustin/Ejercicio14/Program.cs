using System;

namespace Ejercicio14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string numeroUsuarioStr;
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;

            Console.WriteLine("Ingrese la medidad del lado del cuadrado (en cm)");
            numeroUsuarioStr = Console.ReadLine();
            ladoCuadrado = double.Parse(numeroUsuarioStr);

            Console.WriteLine("Ingrese la medidad de la base del triangulo (en cm)");
            numeroUsuarioStr = Console.ReadLine();
            baseTriangulo = double.Parse(numeroUsuarioStr);

            Console.WriteLine("Ingrese la medidad de la altura del triangulo (en cm)");
            numeroUsuarioStr = Console.ReadLine();
            alturaTriangulo = double.Parse(numeroUsuarioStr);

            Console.WriteLine("Ingrese la medidad del radio del circulo (en cm)");
            numeroUsuarioStr = Console.ReadLine();
            radioCirculo = double.Parse(numeroUsuarioStr);

            Console.Write("El area del cuadrado es (cm): ");
            Console.WriteLine(CalculoDeArea.CalcularCuadrado(ladoCuadrado));

            Console.Write("El area del triangulo es (cm): ");
            Console.WriteLine(CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo));

            Console.Write("El area del circulo es (cm): ");
            Console.WriteLine(CalculoDeArea.CalcularCirculo(radioCirculo));
        }
    }
}
