using System;

namespace Ejercicio05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numeroUsuario;
            string numeroUsuarioStr;
            int acumuladorUno = 0;
            int acumuladorDos = 0;

            Console.WriteLine("Ingrese el numero: ");
            numeroUsuarioStr = Console.ReadLine();

            numeroUsuario = int.Parse(numeroUsuarioStr);

            for(int i = 5; i <= numeroUsuario; i++)
            {

                for(int a = 1; a<i; a++)
                {
                    acumuladorUno = acumuladorUno + a;
                }

                for (int j = i + 1; acumuladorDos < acumuladorUno; j++)
                {
                        acumuladorDos = acumuladorDos + j;

                }

                if(acumuladorUno == acumuladorDos)
                {
                    Console.WriteLine($"{i} es un centro numerico");
                }

                acumuladorDos = 0;
                acumuladorUno = 0;

            }

        }
    }
}
