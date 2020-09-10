using System;

namespace ejercicio07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string numeroUsuario;

            DateTime fecha = DateTime.Now;
            DateTime nacimiento = new DateTime(2002, 02, 07);
            double dias;

            dias = fecha.Subtract(nacimiento).TotalDays;

            Console.WriteLine($"{dias}");


        }
    }
}
