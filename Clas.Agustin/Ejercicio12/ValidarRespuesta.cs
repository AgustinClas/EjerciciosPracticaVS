using System;
namespace Ejercicio12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char respuesta)
        {
            bool validacion = false;

            if (respuesta == 's' || respuesta == 'S')
            {
                validacion = true;
            }

            return validacion;
        }
    }
}
