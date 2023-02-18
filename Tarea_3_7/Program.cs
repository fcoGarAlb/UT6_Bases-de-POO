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
            // DateTime hoy = DateTime.Today;
            DateTime hoy = new DateTime(2023, 2, 3);

            ImprimeMesFecha(hoy);
        }

        static void ImprimeMesFecha(DateTime fecha)
        {
            DateTime primerDiaMes = new DateTime(fecha.Year, fecha.Month, 1);
            int diaSemana = (int) primerDiaMes.DayOfWeek;
            int numDiasMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
                                   
            StringBuilder calendario = new StringBuilder();

            if (diaSemana == 0) diaSemana = 7;
            int hueco = diaSemana - 1;

            calendario.Append((MesesAnyo) fecha.Month + " " + fecha.Year + "\n\nLu ma mi ju vi sá do\n");
            calendario.Insert(calendario.Length, "   ", hueco);
            
            for (int i = 0; i < numDiasMes; i++)
            {
                if ((diaSemana + i) % 7 == 0)
                    calendario.Append((i + 1).ToString("D2") + " \n");
                else
                    calendario.Append((i + 1).ToString("D2") + " ");
            }
            
            Console.WriteLine(calendario.ToString() + "\n");          
        }
    }
}
