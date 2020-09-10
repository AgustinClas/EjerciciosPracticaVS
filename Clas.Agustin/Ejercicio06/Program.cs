using System;

namespace Ejercicio06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string numeroUsuarioStr;
            int numeroInicio;
            int numeroFinal;
            int flag = 0;
            
            Console.WriteLine("Ingrese el ano de inicio: ");
            numeroUsuarioStr = Console.ReadLine();
            numeroInicio = int.Parse(numeroUsuarioStr);

            Console.WriteLine("Ingrese el ultimo ano: ");
            numeroUsuarioStr = Console.ReadLine();
            numeroFinal = int.Parse(numeroUsuarioStr);

            for(int i = numeroInicio; i < numeroFinal; i++)
            {
                if(i % 4 == 0)
                {
                    flag = 1;

                    if(i % 100==0)
                    {
                        flag = 0;

                        if(i % 400 == 0)
                        {
                            flag = 1;
                        }
                    }
                }

                if(flag == 1)
                {
                    Console.WriteLine($"{i} es un ano bisiesto");
                    flag = 0;
                }

                
            }
        }
    }
}
