/* Crea una aplicación que solicita una cadena por pantalla y devuelve cada letra en
una línea con la mayúsculas o minúsculas intercambiadas. Utiliza un método al que
le pases la cadena dada por el usuario e imprima los datos como se dice en el
enunciado */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = string.Empty;

            Console.WriteLine("Dame una cadena de texto: ");
            cadena = Console.ReadLine();

            Console.WriteLine("Has escrito ... " + cadena + "\nPero yo lo prefiero así ... ");
            MuestraCambiaVocales(cadena);
         
        }

        static void MuestraCambiaVocales( string cadena )
        {
            for ( int i = 0; i < cadena.Length; i++)
            {

                if (EsVocal(cadena[i]))
                    Console.Write((char.IsUpper(cadena[i])) ? char.ToLower(cadena[i]) : char.ToUpper(cadena[i]));
                else
                    Console.Write(cadena[i]);
            }
            Console.WriteLine();
        }

        static bool EsVocal( char letra )
        {
            bool ok;

            switch (char.ToLower(letra))
            {
                case 'a': ok = true; break;
                case 'e': ok = true; break;
                case 'i': ok = true; break;
                case 'o': ok = true; break;
                case 'u': ok = true; break;
                case 'á': ok = true; break;
                case 'é': ok = true; break;
                case 'í': ok = true; break;
                case 'ó': ok = true; break;
                case 'ú': ok = true; break;
                default: ok = false; break;
            }

            return ok;
        }
    }
}
