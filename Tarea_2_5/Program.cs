using System;

namespace Tarea_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            DateTime fechaNacimiento;
            int anyo, mes, dia;

            Console.Write("Dime tu año de nacimiento: ");
            anyo = int.Parse(Console.ReadLine());

            Console.Write("Dime tu mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Dime tu día de nacimiento: ");
            dia = int.Parse(Console.ReadLine());

            fechaNacimiento = new DateTime(anyo, mes, dia);
            TimeSpan diferencia = hoy.Subtract(fechaNacimiento);

            Console.WriteLine($"\nTienes {Math.Truncate((diferencia.TotalDays / 365f))} años");


        }
    }
}
