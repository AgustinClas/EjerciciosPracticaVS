using System;

namespace Ejercicio04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int cantidad = 0;
            int acumulador = 0;



            for (int i = 6; cantidad < 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acumulador = acumulador + j;
                    }
                }


                if (acumulador == i)
                {
                    Console.WriteLine("{0} es un numero perfecto", i);
                    cantidad++;
                }

                acumulador = 0;
            }

        }
        
    }
}
