using System;
namespace Ejercicio08
{
    public class empleados
    {
        public float valorHora;
        public int horasTrabajadas;
        public string nombre;
        public int antiguedad;
        private float sueldoBruto;
        private float sueldoNeto;
        

        public empleados()
        {
            valorHora = 0;
            horasTrabajadas = 0;
            nombre = "";
            antiguedad = 0;
        }

        public empleados(float valorHora1, int horasTrabajadas1, string nombre1, int antiguedad1)
        {
            valorHora = valorHora1;
            horasTrabajadas = horasTrabajadas1;
            nombre = nombre1;
            antiguedad =antiguedad1;
        }

        public static empleados CargarDatos()
        {
            string nombreEmpleado;
            string numeroUsuario;
            float valorHora;
            int horasTrabajadas;
            int antiguedad;
            empleados empleado;

            //tomamos los datos de los empleados

            Console.WriteLine("Ingrese el nombre del empleado");
            nombreEmpleado = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la hora");
            numeroUsuario = Console.ReadLine();
            valorHora = int.Parse(numeroUsuario);

            Console.WriteLine("Ingrese la cantidad de horas trabajadas por el empleado");
            numeroUsuario = Console.ReadLine();
            horasTrabajadas = int.Parse(numeroUsuario);

            Console.WriteLine("Ingrese la antiguedad del empleado");
            numeroUsuario = Console.ReadLine();
            antiguedad = int.Parse(numeroUsuario);

            //llamos al constructor pasandole variables

            empleado = new empleados(valorHora, horasTrabajadas, nombreEmpleado, antiguedad);

            return empleado;

        }

        public void Calcular()
        {
            //calculamos sueldo bruto y sueldo neto

            this.sueldoBruto = this.horasTrabajadas * this.valorHora + antiguedad * 150;
            this.sueldoNeto = (float)(this.sueldoBruto * 0.77);

        }

        public void mostrarEmpleado()
        {
            Console.WriteLine($"Nombre: {this.nombre}");
            Console.WriteLine($"Valor hora: {this.valorHora}");
            Console.WriteLine($"Horas trabajadas: {this.horasTrabajadas}");
            Console.WriteLine($"Antiguedad: {this.antiguedad}");
            Console.WriteLine($"Sueldo Bruto: {this.sueldoBruto}");
            Console.WriteLine($"Descuentos: {this.sueldoBruto - this.sueldoNeto}");
            Console.WriteLine($"Sueldo Neto: {this.sueldoNeto}");

            Console.WriteLine("_______________________________\n");
        }
    }
}
