/* Crea una aplicación que muestre el calendario del mes actual. Utiliza un método
para realizar la impresión por pantalla. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_7
{
    class Program
    {
        public enum MesesAnyo { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Today;

            ImprimeMesFecha(hoy);
        }

        static void ImprimeMesFecha(DateTime fecha)
        {
            int[,] mes = new int[5, 7];

            int diaSemana = (int) fecha.DayOfWeek;
            int numDiasMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            int cont = 1;

            for (int s = 0; s < mes.GetLength(0) && cont <= numDiasMes; s++)
            {
                for (int d = 0; d < mes.GetLength(1) && cont <= numDiasMes; d++)
                {
                    mes[s, d] = cont++;
                }
            }

            cont = 1;
            Console.WriteLine((MesesAnyo) fecha.Month + " " + fecha.Year);
            for (int s = 0; s < mes.GetLength(0) && cont <= numDiasMes; s++)
            {
                for (int d = 0; d < mes.GetLength(1) && cont <= numDiasMes; d++)
                {
                    Console.Write( mes[s, d] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
