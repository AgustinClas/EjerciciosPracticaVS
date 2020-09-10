using System;
using System.Collections.Generic;

namespace Ejercicio16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string numeroUsuarioStr;
            byte notaUno;
            byte notaDos;
            List<Alumno> alumnos = new List<Alumno>() {
                new Alumno("Juan", "Gutierrez", 12345),
                new Alumno("Carlos", "Gonzalez", 19999),
                new Alumno("Cristian", "Fernandez", 77777)
            };


            for (int i=0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la nota del primer parcial");
                numeroUsuarioStr = Console.ReadLine();
                notaUno = byte.Parse(numeroUsuarioStr);

                Console.WriteLine("Ingrese la nota del segundo parcial");
                numeroUsuarioStr = Console.ReadLine();
                notaDos = byte.Parse(numeroUsuarioStr);

                alumnos[i].Estudiar(notaUno, notaDos);
                alumnos[i].Calcular();
            }

            for(int i=0; i < 3; i++)
            {
                alumnos[i].mostrar();
            }
        }
    }
}
