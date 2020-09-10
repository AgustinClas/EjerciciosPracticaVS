using System;

namespace EjercicioClase02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";

            Console.WriteLine(Sello.imprimir());
            Sello.borrar();
            Console.WriteLine(Sello.imprimir());

            Console.ReadKey(true);

            Sello.mensaje = "lalala";

            Console.WriteLine(Sello.ArmarFormatoMensaje());
            Console.WriteLine(Sello.mensaje);
            Console.WriteLine(Sello.recuadro);

        }
    }
}
