using System;
namespace Ejercicio11
{
    public class Validacion
    {
        public Validacion()
        {
           
        }

        public static bool Validar(int valor, int min, int max)
        {
            //inciamos la variable como falsa y nos ahorramos hacer un else
            bool validacion = false;

            if(valor <= max && valor >= min)
            {
                validacion = true;
            }
            return validacion;
        }
    }
}
