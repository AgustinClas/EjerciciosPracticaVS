using System;

namespace Ejercicio03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numeroMax;
            string numeroStr;
            int flag=0;

            Console.WriteLine("Ingrese el numero: ");
            numeroStr = Console.ReadLine();

            numeroMax = int.Parse(numeroStr);

            for(int i=2; i< (numeroMax + 1); i++)
            {
                for(int j=2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("{0} es un numero primo.", i);
                }

                flag = 0;
            }
        }
    }
}
