using System;
namespace Ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularTriangulo(double baseT, double altura)
        {
            return baseT * altura / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI * (Math.Pow(radio, 2));
        }
    }
}
