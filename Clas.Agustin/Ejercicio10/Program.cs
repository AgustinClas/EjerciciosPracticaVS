using System;

namespace Ejercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numeroUsuario;
            string numeroStr;
            string asteriscos = "*";
            int j = 0;
            string espacios = "";

            Console.WriteLine("Ingrese el numero: ");
            numeroStr = Console.ReadLine();

            if (int.TryParse(numeroStr, out numeroUsuario))
            {
                for (int i = numeroUsuario; i > 0; i--)
                {
                    //los espacios de cada lado seran iguales a la cantidad de las filas
                    do
                    {
                        espacios += " ";
                        j++;

                    } while (j != i);

                    Console.WriteLine($"{espacios}{asteriscos}{espacios}");
                    asteriscos = "*" + asteriscos + "*";

                    //reiniciamos variables de ordenamiento
                    espacios = "";
                    j = 0;
                }
            }
        }
    }
}
