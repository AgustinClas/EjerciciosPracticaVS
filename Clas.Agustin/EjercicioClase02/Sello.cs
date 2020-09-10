using System;
namespace EjercicioClase02
{
    public class Sello
    {
        
        public static string mensaje;

        public static string recuadro;

        public static ConsoleColor color;

            public static string imprimir()
            {
                Console.Write("...");
                return Sello.mensaje;
            }

            public static void borrar()
            {
                Sello.mensaje = "";
            }

        public static string ArmarFormatoMensaje()
        {
            for(int i=0; i < mensaje.Length; i++){
                recuadro += "*";
            }

            return recuadro;
        }

            public static void ImprimirEnColor()
            {
            Sello.color = ConsoleColor.Red;

            Console.ForegroundColor = Sello.color;

            Console.WriteLine(ArmarFormatoMensaje());

            Sello.color = ConsoleColor.Gray;

            Console.ForegroundColor = Sello.color;
        }
        
    }
             
        
}
    

