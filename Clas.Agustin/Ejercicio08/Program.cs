using System;
using System.Collections.Generic;

namespace Ejercicio08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string cantidadEmpleadosStr;
            int cantidadEmpleados;

            Console.WriteLine("Ingrese la cantidad de empleados");
            cantidadEmpleadosStr = Console.ReadLine();
            cantidadEmpleados = int.Parse(cantidadEmpleadosStr);

            List<empleados> empleadosList = new List<empleados>();
            empleados emplead2 = new empleados();


            for (int i = 0; i < cantidadEmpleados; i++)
            {
                empleadosList.Add(empleados.CargarDatos());
                empleadosList[i].Calcular();
            }

            //separo la toma de datos de la muestra de los resultados
            Console.WriteLine("_______________________________\n\n");

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                empleadosList[i].mostrarEmpleado();
            }
        }
    }
}
