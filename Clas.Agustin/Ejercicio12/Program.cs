using System;

namespace Ejercicio12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int acumulador = 0;
            string numeroUsuarioStr;
            int numeroUsuario;
            char respuesta;

            do
            {
                Console.WriteLine("\nIngrese un numero");
                numeroUsuarioStr = Console.ReadLine();

                if (int.TryParse(numeroUsuarioStr, out numeroUsuario))
                {
                    acumulador += numeroUsuario;
                }

                Console.WriteLine("Desea continuar?");
                respuesta = (char)Console.Read();

            } while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.WriteLine($"\nLa suma de los numeros ingresados es {acumulador}");

        }
    }
}
