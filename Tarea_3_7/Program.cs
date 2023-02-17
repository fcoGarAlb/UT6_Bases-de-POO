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
           

            Console.WriteLine("Lu ma mi ju vi sá do");
            StringBuilder calendario = new StringBuilder();

            int cont = 0; 

            for ( int i = 0; i < diaSemana; i++)
            {
                calendario.Append("   ");
                cont++;
            }

            for (int i = 0; i < numDiasMes; i++  )
            {
                if ((diaSemana + i) % 7 != 0)
                    calendario.Append($"{i + 1} ");
                else
                    calendario.Append($"{i + 1} \n");
            }

            Console.Write(calendario.ToString());
            
        }
    }
}
