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

namespace Tarea_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "La noche se avecina, ahora empieza mi guardia. No terminará hasta el día de mi " +
                           "muerte. No tomaré esposa, no poseeré tierras, no engendraré hijos. No llevaré " + 
                           "corona, no alcanzaré la gloria. Viviré y moriré en mi puesto. Soy la espada en la " +
                           "oscuridad. Soy el vigilante del Muro. Soy el fuego que arde contra el frío, la luz que " +
                           "trae el amanecer, el cuerno que despierta a los durmientes, el escudo que defiende " +
                           "los reinos de los hombres. Entrego mi vida y mi honor a la Guardia de la Noche, " +
                           "durante esta noche y todas las que estén por venir. ";

            int consonates, vocales_a, vocales_e, vocales_i, vocales_o, vocales_u;
            consonates = vocales_a = vocales_e = vocales_i = vocales_o = vocales_u = 0;
            char caracterMin;

            foreach (char caracter in texto)
            {
                caracterMin = char.ToLower(caracter);

                if( char.IsLetter(caracterMin) )
                {
                    if (caracterMin == 'a')
                        vocales_a++;
                    else if (caracterMin == 'e')
                        vocales_e++;
                    else if (caracterMin == 'i')
                        vocales_i++;
                    else if (caracterMin == 'o')
                        vocales_o++;
                    else if (caracterMin == 'u')
                        vocales_u++;
                    else
                        consonates++;
                }
            }

            Console.WriteLine($"El texto tiene:\n\n{consonates} consonante/s,\n" +
                              $"{vocales_a} vocal/es 'a',\n" +
                              $"{vocales_e} vocal/es 'e',\n" +
                              $"{vocales_i} vocal/es 'i',\n" +
                              $"{vocales_o} vocal/es 'o',\n" +
                              $"{vocales_u} vocal/es 'u'\n\n");

        }
    }
}
