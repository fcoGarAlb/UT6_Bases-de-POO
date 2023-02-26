/* Crea un programa dónde solicitas al usuario el número de personas que va a
introducir. Vas a guardar los datos de las personas en un array de objetos Persona.
Una vez introducidos todos los datos imprime por pantalla los datos de todas las
personas introducidas. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPers;

            Console.Write("Dime el número de personas a introducir: ");
            numPers = int.Parse(Console.ReadLine());

            Persona[] personas = new Persona[numPers];

            for (int i = 0; i < numPers; i++)
            {
                do
                {
                    Console.WriteLine($"Datos de la persona[{i}]");
                } while (!Persona.introducirPersona(ref personas[i]));
            }

            foreach( Persona p in personas)
            {
                Console.WriteLine(p.ToString() + "\n");
            }
        }
    }
}
