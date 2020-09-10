using System;

namespace Ejercicio09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numeroUsuario;
            string numeroStr;
            string asteriscos = "*";

            Console.WriteLine("Ingrese el numero: ");
            numeroStr = Console.ReadLine();

            if (int.TryParse(numeroStr, out numeroUsuario))
            {
                for (int i = 1; i <= numeroUsuario; i++)
                {
                    Console.WriteLine($"{asteriscos}");
                    asteriscos = asteriscos + "**";
                }
            }
        }
    }
}
