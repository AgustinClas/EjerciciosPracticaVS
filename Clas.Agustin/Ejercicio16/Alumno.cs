using System;
namespace Ejercicio16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.nota1 = 0;
            this.nota2 = 0;
            this.notaFinal = 0;

        }

        public void Estudiar(byte notaUno, byte notaDos)
        {

            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void Calcular()
        {
            Random notaAleatoria = new Random();

            if (this.nota1 > 3 && this.nota2 > 3)
            {
                notaFinal = notaAleatoria.Next(1, 10);
            }
            else
            {
                notaFinal = -1;
            }
        }

        public void mostrar()
        {
            Console.WriteLine($"\n{this.nombre} {this.apellido}");
            Console.WriteLine($"Nota 1: {this.nota1}");
            Console.WriteLine($"Nota 2: {this.nota2}");
            if (this.notaFinal != -1)
            {
                Console.WriteLine($"Nota final: {this.notaFinal}");
            }
            else
            {
                Console.WriteLine("Alumno desaprobado");
            }
            Console.WriteLine($"Legajo: {this.legajo}");
            Console.WriteLine("-----------------------------");
        }
    }
}
