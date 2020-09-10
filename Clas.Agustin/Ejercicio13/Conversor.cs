using System;
using System.Text;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(double numEntero)
        {
            string numeroBinario = "";
            double resto;
           

            while(numEntero > 1)
            {
                resto = numEntero % 2;
                numEntero = Math.Floor(numEntero / 2);

                numeroBinario = resto.ToString() + numeroBinario;

            }

            numeroBinario = numEntero.ToString() + numeroBinario;

            return numeroBinario;


        }

       public static double BinarioDecimal(string numBinario)
        {
            StringBuilder numeroBinario = new StringBuilder(numBinario);
            double numeroEntero = 0;
            Console.WriteLine(numeroBinario.Length - 1);

            for (int i = (numeroBinario.Length - 1); i>=0; i--)
            {
                if (numeroBinario[i] == '1')
                {
                    Console.WriteLine(Math.Pow(2, i));
                    numeroEntero = Math.Pow(2,i) + numeroEntero;

                }
        
            }

            return numeroEntero;
            
        }
    }
}
