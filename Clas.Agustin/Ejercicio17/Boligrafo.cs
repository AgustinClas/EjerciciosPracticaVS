using System;
namespace Ejercicio17
{
    public class Boligrafo
    {
        public static short cantidadMaxima=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if((this.tinta + (tinta)) <= Boligrafo.cantidadMaxima && (this.tinta + (tinta)) >= cantidadMaxima)
            {
                this.tinta = (short)(this.tinta + tinta);
            }
        }

        public void Recargar()
        {
            this.SetTinta((short)(100 - this.tinta));
        }

        public bool pintar(short tinta, out string pintura)
        {
            bool pintar = false;
            pintura = "";
            short oldTinta = this.GetTinta();
            this.SetTinta(-100);


            if (oldTinta > 0)
            {

                if(tinta < oldTinta)
                {
                    for(short i = tinta; i > 0; i--)
                    {
                        pintura += '*';
                    }
                }
                else
                {

                    for(short i = oldTinta; i>0; i--)
                    {
                        pintura += '*';
                    }
                }
                Console.WriteLine("\n");
                pintar = true;
            }

            return pintar;
        }
    }
}
