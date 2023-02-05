using System;

namespace Tarea_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const float G = 9.8f;
            float tiempo;

            Console.WriteLine("- Calculo de la velocidad en caida libre -");
            Console.WriteLine("Velocidad = Gravedad (m/s^2)* tiempo (s)");
            Console.Write("Dime el tiempo: ");
            tiempo = float.Parse(Console.ReadLine());

            if (tiempo <= 0)
            {
                Console.WriteLine("El tiempo de caida no puede ser cero, ni negativo");
            }
            else
            {
                Console.WriteLine("Velocidad = " + G + " * " + tiempo + " = " + (G * tiempo) + " m/s");
            }
        }
    }
}