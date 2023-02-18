using System;

namespace Tarea_3_9_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            Console.WriteLine("- Generador de números de la primitiva -\n");
            for (int cont = 0; cont < 6; cont++)
                Console.WriteLine("  Número: " + GeneraNumAleatorio(numAleatorio, 1, 49));

            Console.WriteLine("\nComplementario: " + GeneraNumAleatorio(numAleatorio, 1, 49));
            Console.WriteLine("Reintegro: " + GeneraNumAleatorio(numAleatorio, 0, 9));
        }


        static int GeneraNumAleatorio(Random numAle, int valorInf, int valorSup)
        {
            return numAle.Next(valorInf, valorSup + 1);
        }
    }
}