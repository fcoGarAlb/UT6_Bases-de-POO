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
            string[] bytes;
            int b0 = 0, b1 = 0, b2 = 0, b3 = 0;

            do
            {
                Console.WriteLine("Dame una dirección IP: ");
                bytes = Console.ReadLine().Split('.');

                if (bytes.GetLength(0) == 4 && int.TryParse(bytes[0], out b3)
                                             && int.TryParse(bytes[1], out b2)
                                             && int.TryParse(bytes[2], out b1)
                                             && int.TryParse(bytes[3], out b0)
                                             && b3 >= 0 && b3 <= 255
                                             && b2 >= 0 && b2 <= 255
                                             && b1 >= 0 && b1 <= 255
                                             && b0 >= 0 && b0 <= 255)
                {
                    ok = true;
                    Console.WriteLine("La direccion es válida en formato...\n");
                }
                else
                    Console.WriteLine("La dirección IP está mal escrita\n");

            } while (!ok);

            Console.WriteLine("Has escrito: " + b3.ToString() + "." + b2.ToString() + "." + b1.ToString() + "." + b0.ToString());
            
        }
    }
}
