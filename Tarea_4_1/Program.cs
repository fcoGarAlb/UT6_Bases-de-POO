/* Solicita al usuario una dirección IP. Te recuerdo que una dirección IP va de
000.000.000.000 a 255.255.255.255. Comprueba si la dirección IP es válida. Este
ejercicio puedes resolverlo de varias formas. Investiga sobre el método split de array. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            string[] digito;
            int d1 = 0, d2 = 0, d3 = 0, d4 = 0;

            do
            {
                Console.WriteLine("Dame una dirección IP: ");
                digito = Console.ReadLine().Split('.');

                if (digito.GetLength(0) == 4 && int.TryParse(digito[0], out d1)
                                             && int.TryParse(digito[1], out d2)
                                             && int.TryParse(digito[2], out d3)
                                             && int.TryParse(digito[3], out d4)
                                             && d1 >= 0 && d1 <= 255
                                             && d2 >= 0 && d2 <= 255
                                             && d3 >= 0 && d3 <= 255
                                             && d4 >= 0 && d4 <= 255)
                {
                    ok = true;
                    Console.WriteLine("La direccion es válida en formato...\n");
                }
                else
                    Console.WriteLine("La dirección IP está mal escrita\n");

            } while (!ok);

            Console.WriteLine("Has escrito: " + d1.ToString() + "." + d2.ToString() + "." + d3.ToString() + "." + d4.ToString());
            
        }
    }
}
