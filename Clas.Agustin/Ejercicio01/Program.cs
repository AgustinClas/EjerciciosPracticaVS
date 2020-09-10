using System;
using System.Collections.Generic;

namespace Ejercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<double> numeros = new List<double>();
            double acumulador = 0;
            double aux;
            string aux2;

            for (int i=0; i < 5; i++)
            {

                Console.Write("Ingrese un numero: ");
                aux2 = Console.ReadLine();

                if(Double.TryParse(aux2, out aux)){
                    numeros.Add(aux);
                }
                else
                {
                    Console.WriteLine("No se pudo tomar el numero");
                    i--;
                }

            }

            numeros.ForEach(a => acumulador += a);
            numeros.Sort();

            Console.WriteLine($"El numero minimo es {numeros[0]}");
            Console.WriteLine($"El numero maximo es {numeros[4]}");
            Console.WriteLine($"El promedio es {acumulador / 5}");
        }
    }
}
