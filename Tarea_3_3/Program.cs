/* Confeccionar un método que muestre los primeros 10 números pares. En caso que
le pasemos un parámetro opcional mostrar tantos pares como indica el parámetro. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarPares();
            MostrarPares(5);
        }

        static void MostrarPares( int numPares = 10 )
        {
            for (int cont = 0, numPar = 2; cont < numPares; cont++, numPar += 2)
                Console.Write(numPar + ", ");
        
            Console.WriteLine("\b\b ");
        }
    }
}
