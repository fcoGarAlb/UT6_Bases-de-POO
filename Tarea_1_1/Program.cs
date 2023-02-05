// EL primer ejercicio de clase
// Otra línea de comentarios
using System;

namespace Tarea_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1, palabra2;

            Console.Write("Dime una palabra: ");
            palabra1 = Console.ReadLine();

            Console.Write("Dime otra palabra: ");
            palabra2 = Console.ReadLine();

            if (palabra1 == palabra2)
            {
                Console.WriteLine("Las dos palabras son iguales");
            }
            else
            {
                Console.WriteLine("Las dos palabras son distintas");
            }
        }
    }
}