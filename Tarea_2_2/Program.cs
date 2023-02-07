/* Solicita al usuario un texto que deberás buscar si existe dentro del texto que te doy a
continuación. El usuario además debe indicar si busca coincidencia exacta de
mayúsculas y minúsculas o no. Devuelve el número de ocurrencias del texto
introducido. Si el usuario introduce espacios antes o después de la frase introducida
no los tendremos en cuenta (busca un método en la clase String que pueda ayudarte
para esto).
“La noche se avecina, ahora empieza mi guardia. No terminará hasta el día de mi
muerte. No tomaré esposa, no poseeré tierras, no engendraré hijos. No llevaré
corona, no alcanzaré la gloria. Viviré y moriré en mi puesto. Soy la espada en la
oscuridad. Soy el vigilante del Muro. Soy el fuego que arde contra el frío, la luz que
trae el amanecer, el cuerno que despierta a los durmientes, el escudo que defiende
los reinos de los hombres. Entrego mi vida y mi honor a la Guardia de la Noche,
durante esta noche y todas las que estén por venir.” */

using System;
using System.Text.RegularExpressions;

namespace Tarea_2_2
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
            
            string textoMin = texto.ToLower();

            string cadenaBuscar;
            bool coincidencia;
            int ocurrencias;

            Console.WriteLine(texto + "\n");
            Console.WriteLine("Dime una frase a buscar: ");
            cadenaBuscar = (Console.ReadLine()).Trim(' ');
            Console.WriteLine("¿Quieres una coincidencia exacta (S/N)? ");
            coincidencia = Char.ToUpper(Char.Parse(Console.ReadLine())) == 'S';

            if (coincidencia)
                ocurrencias = Regex.Matches(texto, cadenaBuscar).Count;            
            else
                ocurrencias = Regex.Matches(textoMin, cadenaBuscar.ToLower()).Count; 

            Console.WriteLine($"El número de ocurrencias{((coincidencia)? " exactas " : " ")}para '{cadenaBuscar}' es {ocurrencias}");
        }
    }
}
