using System;

namespace Tarea_2_3
{
    class Program
    {
        public enum DiasSemana { Domingo = 0, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado };
        static void Main(string[] args)
        {
            //DateTime fecha = new DateTime( 2023, 02, 12);
            DateTime fecha = DateTime.Now;

            Console.WriteLine("Veamos si hoy toca jugar a la primitiva");

            DiasSemana hoy = (DiasSemana) fecha.DayOfWeek;
            Console.WriteLine($"Hoy es {hoy}");

            if( hoy == DiasSemana.Jueves || hoy == DiasSemana.Sabado || hoy == DiasSemana.Lunes)
            {
                Console.WriteLine("Estas de suerte, vamos a jugar a 'La Primitiva'");
            }
            else
            {
                Console.Write("Uffs, parece que ... ");

                if (hoy > DiasSemana.Lunes && hoy < DiasSemana.Jueves)
                    Console.WriteLine("Tendras que esperarte hasta el Jueves");
                else if (hoy > DiasSemana.Jueves && hoy < DiasSemana.Sabado)
                    Console.WriteLine("Tendras que esperarte hasta el Sábado");
                else
                    Console.WriteLine("Tendras que esperarte hasta el Lunes");
            }



        }
    }
}
