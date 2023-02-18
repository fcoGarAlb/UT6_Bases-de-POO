/* Dado el siguiente texto que guardarás en un string debes contar el número de
consonantes, vocales a, vocales e, vocales i, vocales o, vocales u.
“La noche se avecina, ahora empieza mi guardia. No terminará hasta el día de mi
muerte. No tomaré esposa, no poseeré tierras, no engendraré hijos. No llevaré
corona, no alcanzaré la gloria. Viviré y moriré en mi puesto. Soy la espada en la
oscuridad. Soy el vigilante del Muro. Soy el fuego que arde contra el frío, la luz que
trae el amanecer, el cuerno que despierta a los durmientes, el escudo que defiende
los reinos de los hombres. Entrego mi vida y mi honor a la Guardia de la Noche,
durante esta noche y todas las que estén por venir.” */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_9_2_1
{

    class Program
    {
        //static string texto = "avión";
        static string texto = "La noche se avecina, ahora empieza mi guardia. No terminará hasta el día de mi " +
                              "muerte. No tomaré esposa, no poseeré tierras, no engendraré hijos. No llevaré " +
                              "corona, no alcanzaré la gloria. Viviré y moriré en mi puesto. Soy la espada en la " +
                              "oscuridad. Soy el vigilante del Muro. Soy el fuego que arde contra el frío, la luz que " +
                              "trae el amanecer, el cuerno que despierta a los durmientes, el escudo que defiende " +
                              "los reinos de los hombres. Entrego mi vida y mi honor a la Guardia de la Noche, " +
                              "durante esta noche y todas las que estén por venir. ";
        
        static void Main(string[] args)
        {
   
            int consonates, vocales_a, vocales_e, vocales_i, vocales_o, vocales_u;

            CuentaLetras(out consonates, out vocales_a, out vocales_e, out vocales_i, out vocales_o, out vocales_u);

            Console.WriteLine($"El texto tiene:\n\n{consonates} consonante/s,\n" +
                              $"{vocales_a} vocal/es 'a',\n" +
                              $"{vocales_e} vocal/es 'e',\n" +
                              $"{vocales_i} vocal/es 'i',\n" +
                              $"{vocales_o} vocal/es 'o',\n" +
                              $"{vocales_u} vocal/es 'u'\n\n");
        }

        static void CuentaLetras(out int consonates, out int vocales_a, out int vocales_e, out int vocales_i, out int vocales_o, out int vocales_u)
        {
            consonates = vocales_a = vocales_e = vocales_i = vocales_o = vocales_u = 0;
            char caracterMin;

            foreach (char caracter in texto)
            {
                caracterMin = char.ToLower(caracter);

                if (char.IsLetter(caracterMin))
                {
                    if (caracterMin == 'a' || caracterMin == 'á')
                        vocales_a++;
                    else if (caracterMin == 'e' || caracterMin == 'é')
                        vocales_e++;
                    else if (caracterMin == 'i' || caracterMin == 'í')
                        vocales_i++;
                    else if (caracterMin == 'o' || caracterMin == 'ó')
                        vocales_o++;
                    else if (caracterMin == 'u' || caracterMin == 'ú')
                        vocales_u++;
                    else
                        consonates++;
                }
            }
        }
    }

}
