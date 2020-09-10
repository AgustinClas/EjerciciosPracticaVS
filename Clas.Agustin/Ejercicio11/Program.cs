using System;
using System.Collections.Generic;

namespace Ejercicio11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numeros = new  List<int>();
            string numeroUsuario;
            int numeroAux;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entre el -100 y 100:");
                numeroUsuario = Console.ReadLine();
                numeroAux = int.Parse(numeroUsuario);

                if (Validacion.Validar(numeroAux,  -100, 100))
                {
                    numeros.Add(numeroAux);
                    acumulador += numeroAux;

                }
                else
                {
                    Console.WriteLine("Error. El numero no es valido\n");
                }
            } while (numeros.Count != 10);

            //ordenamos la lista para obtener max y min con el indice 9 y 0
            numeros.Sort();

            Console.WriteLine($"El numero minimo es {numeros[0]}");
            Console.WriteLine($"El numero maximo es {numeros[9]}");
            Console.WriteLine($"El promedio es {acumulador / 10}");

        }
    }
}
