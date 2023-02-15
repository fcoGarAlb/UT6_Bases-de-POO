/* Confeccionar un método que me retorne dos valores aleatorios comprendidos entre
1 y 100 mediante parámetros por referencia. Utiliza out para los parámetros. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int valor1, valor2;

            Console.WriteLine("Vamos a generar dos valores aleatorios");
            retorna2Aleatorios(out valor1, out valor2);

            Console.WriteLine($"Primer valor {valor1}");
            Console.WriteLine($"Segundo valor {valor2}\n");

            //Console.ReadLine();
        }

        static void retorna2Aleatorios( out int uno, out int dos)
        {
            Random aleatorio = new Random();

            uno = aleatorio.Next(1, 101);
            dos = aleatorio.Next(1, 101);
        }
    }
}
