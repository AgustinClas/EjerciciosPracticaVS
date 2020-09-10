using System;
namespace EjercicioClase04
{
    public class Cosa
    {
        private int Entero;
        private string Cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.Entero = 0;
            this.Cadena = " ";
            this.fecha = DateTime.Now;
        }

        public Cosa(string cadena):this()
        {
            this.Cadena = cadena;
              
        }

        public Cosa(int entero, string cadena):this(cadena)
        {
            this.Cadena = cadena;
            this.Entero = entero;
            this.fecha = DateTime.Now;
        }

        public void establecerValor(int entero)
        {

        }
    }
}
