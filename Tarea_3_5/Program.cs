/* Crea una aplicación que solicita una cadena y que devuelve el número de palabras
que terminan en vocal. Crea un método que pasada una cadena devuelva el número
de vocales al final de una palabra se han encontrado. El número de vocales se
imprimirá desde el main */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = string.Empty;

            Console.WriteLine("Dime una cadena de texto: ");
            cadena = Console.ReadLine();

            Console.WriteLine($"Hay {CuentaPalabrasFinVocal(cadena)} palabra/s que terminan en vocal");
        }

        static int CuentaPalabrasFinVocal( string cadena)
        {
            int palabrasFinVocal = 0;

            for (int i = 1; i < cadena.Length; i++)
                if (cadena[i] == ' ' && EsVocal(cadena[i - 1]))     palabrasFinVocal++;

            if (EsVocal(cadena[cadena.Length - 1])) palabrasFinVocal++;

            return palabrasFinVocal;
        }

        static bool EsVocal(char letra)
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
