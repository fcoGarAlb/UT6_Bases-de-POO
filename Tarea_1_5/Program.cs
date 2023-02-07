/* Crea un programa para que el usuario intente adivinar un número aleatorio que
previamente has creado. Tendrás que buscar información sobre cómo generar
números aleatorios en C#. El número a generar estará entre 1 y 100. El usuario
podrá tener 3 intentos para acertarlo. Cada vez que el usuario introduzca un número
informarle si ha acertado o no, el número de fallos y si el número a acertar es mayor
o menor. */

using System;


namespace Tarea_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool acertado = false;
            int intentos = 0;
            Random rnd = new Random();
            int numero, numAdivinar = rnd.Next(1, 101);

            Console.WriteLine("- Vamos a jugar a adivinar un número  entre 1 y 100 - " + $"[{numAdivinar}]");
            do
            {
                Console.Write("¿Qué número se te ocurre? ");
                numero = int.Parse(Console.ReadLine());

                if (acertado = (numero == numAdivinar))
                    Console.WriteLine("\n¡¡¡Felicidades, has acertado!!! El número era " + numAdivinar);
                else
                {
                    intentos++;

                    if (intentos < 3)
                        Console.WriteLine("\nEsto es embarazoso...\nTendras que seguir buscando porque el número es " + ((numero > numAdivinar) ? "<menor>" : "<mayor>"));

                    Console.WriteLine($"\nTe has equivocado {intentos} {((intentos == 1) ? "vez" : "veces")}");
                }
                
            } while (intentos < 3 && !acertado);

            if (!acertado)
                Console.WriteLine($"El número era [{numAdivinar}]\n");

            Console.WriteLine("Juego terminado. Pulsa una tecla");
            Console.ReadKey();
        }
    }
}
