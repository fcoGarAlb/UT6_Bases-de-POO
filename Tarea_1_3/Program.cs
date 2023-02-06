/*Vas a programar un programa que calcule la nota de un alumno en el módulo de
Programación. Para el cálculo de la nota del módulo se utilizará la siguiente fórmula:
nota_final = (nota_prácticas * 0, 3) + (nota_examen * 0, 7) + (positivos * 0, 1)
En primer lugar, el programa pedirá el número de alumnos a los que queremos
calcularles la nota e irá pidiendo para cada uno de ellos la nota de prácticas, la nota
del examen y el número de positivos ganados en clase.
Una vez finalices la introducción de datos muestra:
● Nota media de las prácticas de todos los alumnos (media aritmética).
● Nota media final de todos los alumnos (media aritmética de las notas).
● El número de alumnos con nota de evaluación suspenso (<5.0) o
aprobado(>=5.0).
Las notas pueden tener decimales.
Comprueba además que las notas están entre 0 y 10, en el momento que una nota
no tenga el valor correcto no le preguntes por el resto. */

using System;

namespace Tarea_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;
            int numAlum, cont = 0, positivos, suspensos = 0, aprobados = 0;
            float nota_final, nota_practicas, nota_examen;
            float nota_mediaPracticas = 0f, nota_mediaFinal = 0f;

            Console.Write("Dime el número de alumnos para calcular la nota: ");
            numAlum = int.Parse(Console.ReadLine());

            while (cont < numAlum && ok)
            {
                Console.Write($"Nota de prácticas para el alumno{cont}: ");
                nota_practicas = float.Parse(Console.ReadLine());

                if (nota_practicas < 0 || nota_practicas > 10)
                {
                    ok = false;
                }
                else
                {
                    Console.Write($"Nota del examen: ");
                    nota_examen = float.Parse(Console.ReadLine());

                    if (nota_examen < 0 || nota_examen > 10)
                    {
                        ok = false;
                    }
                    else
                    {
                        Console.Write($"Número de positivos: ");
                        positivos = int.Parse(Console.ReadLine());

                        if (positivos < 0)
                        {
                            ok = false;
                        }
                        else
                        {
                            nota_final = (nota_practicas * 0.3f) + (nota_examen * 0.7f) + (positivos * 0.1f);

                            nota_mediaPracticas += nota_practicas;
                            nota_mediaFinal += nota_final;

                            if (nota_final < 5.0f)
                                suspensos++;
                            else
                                aprobados++;

                            cont++;

                            Console.WriteLine(nota_practicas + ", " + nota_examen);
                            Console.WriteLine(nota_mediaPracticas + ", " + nota_mediaFinal);
                        }
                    }
                }
            }

            if (!ok)
            {
                Console.WriteLine("Ufss, parece que algo a salido mal durante la introducción de datos");
            }
            else
            {

                nota_mediaPracticas /= numAlum;
                nota_mediaFinal /= numAlum;

                Console.WriteLine("Nota media de las prácticas de todos los alumnos (media aritmética): " + nota_mediaPracticas);
                Console.WriteLine("Nota media final de todos los alumnos (media aritmética de las notas): " + nota_mediaFinal);
                Console.WriteLine($"El número de alumnos con nota de evaluación suspenso (<5.0) es {suspensos} o aprobado(>=5.0) es {aprobados}");
            }
        }
    }
}