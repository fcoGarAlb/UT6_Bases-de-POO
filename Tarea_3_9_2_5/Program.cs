using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_9_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int anyo, mes, dia;

            Console.Write("Dime tu día de nacimiento: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Dime tu mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Dime tu año de nacimiento: ");
            anyo = int.Parse(Console.ReadLine());
               
            Console.WriteLine($"\nTienes {CalculaAnyos(dia, mes, anyo)} años");
        }

        static int CalculaAnyos(int diaN, int mesN, int anyoN)
        {
            DateTime hoy = DateTime.Today;
            DateTime fechaAuxNac = new DateTime(hoy.Year, mesN, diaN);
            int resComp = DateTime.Compare(fechaAuxNac, hoy);

            return  ( resComp <= 0)? hoy.Year - anyoN :hoy.Year - anyoN - 1;
        }
    }
}