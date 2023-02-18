/* En la tarea 2 programaste este ejercicio:
Genera los números de La Primitiva e imprimelos por pantalla sabiendo que:
a. Son 6 números del 1 al 49.
b. El complementario es un número del 1 al 49.
c. El reintegro es un número del 0 al 9.
Modifícalo para que a la vez que se van generando los números vayas creando poco
a poco la cadena final con el resultado. Utiliza para ello un StringBuilder. La cadena
final con el resultado podría ser algo así: “Los números son: 4,8,15,16,23,42.
Complementario: 13. Reintegro: 5.” */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            StringBuilder resultado = new StringBuilder();

            resultado.Append("- Generador de números de la primitiva -\nLos número son: ");
            for (int cont = 0; cont < 6; cont++)
                resultado.Append(GeneraNumAleatorio(numAleatorio, 1, 49) + ", ");

            resultado.Remove(resultado.Length - 2, 2).Append('.');

            resultado.Append("\nComplementario: " + GeneraNumAleatorio(numAleatorio, 1, 49) +
                             ". Reintegro: " + GeneraNumAleatorio(numAleatorio, 0, 9) + ".");

            Console.WriteLine(resultado);
        }


        static int GeneraNumAleatorio(Random numAle, int valorInf, int valorSup)
        {
            return numAle.Next(valorInf, valorSup + 1);
        }
    }
}
