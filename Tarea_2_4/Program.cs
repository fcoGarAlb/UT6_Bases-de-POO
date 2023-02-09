using System;

namespace Tarea_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            Console.WriteLine("- Generador de números de la primitiva -\n");
            for( int cont = 0; cont < 6; cont++)
                Console.WriteLine( "  Número: " + numAleatorio.Next(1, 50));

            Console.WriteLine("\nComplementario: " + numAleatorio.Next(1, 50));
            Console.WriteLine("Reintegro: " + numAleatorio.Next(1, 10));
        }
    }
}
