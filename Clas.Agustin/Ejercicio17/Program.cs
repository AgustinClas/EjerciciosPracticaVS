using System;

namespace Ejercicio17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boligrafo Azul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo Rojo = new Boligrafo(ConsoleColor.Red, 50);

            string numeroUsuario;
            short tintaAzul;
            short tintaRoja;
            string pinturaUtilizada;

            Console.WriteLine("Ingrese la cantidad de tinta azul que quiere utilizar");
            numeroUsuario = Console.ReadLine();
            tintaAzul = short.Parse(numeroUsuario);

            Console.WriteLine("Ingrese la cantidad de tinta roja que quiere utilizar");
            numeroUsuario = Console.ReadLine();
            tintaRoja = short.Parse(numeroUsuario);

            if (Azul.pintar(tintaAzul, out pinturaUtilizada))
            {
                Console.WriteLine(pinturaUtilizada);
            }
            else
            {
                Console.WriteLine("Este boligrafo no tenia tinta");
            }

            if (Rojo.pintar(tintaRoja, out pinturaUtilizada))
            {
                Console.WriteLine(pinturaUtilizada);
            }
            else
            {
                Console.WriteLine("Este boligrafo no tenia tinta");
            }

            Console.WriteLine("Ingrese la cantidad de tinta azul que quiere utilizar");
            numeroUsuario = Console.ReadLine();
            tintaAzul = short.Parse(numeroUsuario);

            Console.WriteLine("Ingrese la cantidad de tinta roja que quiere utilizar");
            numeroUsuario = Console.ReadLine();
            tintaRoja = short.Parse(numeroUsuario);

            if (Azul.pintar(tintaAzul, out pinturaUtilizada))
            {
                Console.WriteLine(pinturaUtilizada);
            }
            else
            {
                Console.WriteLine("Este boligrafo no tenia tinta");
            }

            if (Rojo.pintar(tintaRoja, out pinturaUtilizada))
            {
                Console.WriteLine(pinturaUtilizada);
            }
            else
            {
                Console.WriteLine("Este boligrafo no tenia tinta");
            }

            Azul.Recargar();
            Rojo.Recargar();

            Console.WriteLine("Ingrese la cantidad de tinta azul que quiere utilizar");
            numeroUsuario = Console.ReadLine();
            tintaAzul = short.Parse(numeroUsuario);

            Console.WriteLine("Ingrese la cantidad de tinta roja que quiere utilizar");
            numeroUsuario = Console.ReadLine();
            tintaRoja = short.Parse(numeroUsuario);

            if (Azul.pintar(tintaAzul, out pinturaUtilizada))
            {
                Console.WriteLine(pinturaUtilizada);
            }
            else
            {
                Console.WriteLine("Este boligrafo no tenia tinta");
            }

            if (Rojo.pintar(tintaRoja, out pinturaUtilizada))
            {
                Console.WriteLine(pinturaUtilizada);
            }
            else
            {
                Console.WriteLine("Este boligrafo no tenia tinta");
            }

        }
    }
}
