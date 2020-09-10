using System;

namespace Ejercicio13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string numeroUsuario;
            string numeroBinario;
            double numeroEntero;
            

            Console.WriteLine("Ingrese un numero entero");
            numeroUsuario = Console.ReadLine();
            numeroEntero = int.Parse(numeroUsuario);

            Console.WriteLine("Ingrese un numero binario");
            numeroUsuario = Console.ReadLine();

            numeroBinario = Conversor.DecimalBinario(numeroEntero);
            numeroEntero = Conversor.BinarioDecimal(numeroUsuario);

            Console.WriteLine($"El numero entero es el {numeroBinario} en binario");
            Console.WriteLine($"El numero binario es el {numeroEntero} en decimal");
        }

        
    }
}
