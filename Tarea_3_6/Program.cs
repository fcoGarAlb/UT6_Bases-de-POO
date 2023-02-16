/* Solicita una fecha al usuario con día, mes y año y calcula el número de días que
quedan para esa fecha. Si la fecha es anterior a hoy informale. Crea un método que
dado un DateTime te devuelve el número de días que quedan para esa fecha, en
caso de que sea una fecha pasada devuelve -1 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaUsuario;
            int anyo, mes, dia, numDias;

            Console.Write("Dime un año: ");
            anyo = int.Parse(Console.ReadLine());

            Console.Write("Dime un mes: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Y un día: ");
            dia = int.Parse(Console.ReadLine());

            fechaUsuario = new DateTime(anyo, mes, dia);

            switch (numDias = comparaFechas(fechaUsuario))
            {
                case -1: Console.WriteLine("La fecha es anterior a la actual"); break;
                case  0: Console.WriteLine("Has introducido la fecha de hoy"); break;
                default: Console.WriteLine($"Quedan {numDias} para esa fecha"); break;
            }
        }

        static int comparaFechas(DateTime fechaUsuario)
        {
            int numDias = 0;
            DateTime hoy = DateTime.Today;
            TimeSpan diferencia = fechaUsuario.Subtract(hoy);
            

            numDias = (int) diferencia.Days;
            
            if (numDias < 0)     numDias = -1;

            return numDias;
        }
    }
}
