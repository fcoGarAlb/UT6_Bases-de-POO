/*Debes implementar un programa para analizar el equipamiento informático de una
empresa. Inicialmente se le pide al usuario el número de equipos de los que se van
a introducir los datos. No es necesario almacenar los datos en ninguna estructura o
array.
Para cada equipo se le pide al usuario que introduzca:
● La cantidad de memoria RAM (en GB).
● El tamaño del disco duro (en GB).
Una vez introducidos todos los datos de los equipos se mostrarán los siguientes
resultados:
● La media de RAM de los equipos.
● El disco duro con el mayor tamaño. Da igual si hay varios equipos con el
mayor tamaño.
● La cantidad de equipos para “ofimática”, “programación” y “diseño 3d” según
lo siguiente:
○ Si el equipo tiene menos de 8 GB de RAM se considera de
“ofimática”.
○ Si el equipo tiene entre 8 GB y 16 GB de RAM (ambos tamaños
inclusives) se comprueba el disco duro. Si el disco duro es menor de
256 GB es de “ofimática”, si el disco tiene entre 256 GB y 512 GB 
(ambos tamaños inclusives) se considera un equipo para
“programación”, mayor de 512GB es de “diseño 3D”
○ Si el equipo tiene más de 16 Gb de RAM se considera un equipo para
“diseño 3d”.*/

using System;

namespace Tarea_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEquipos, ofimatica, programacion, disenyo3d, cont;
            float cantRAM, tamHDD, mediaRAM, mayorHDD;

            mediaRAM = mayorHDD = ofimatica = programacion = disenyo3d = 0;

            Console.Write("Dime el número de equipos a introducir los datos: ");
            numEquipos = int.Parse(Console.ReadLine());

            cont = 0;
            while (cont < numEquipos)
            {
                Console.Write($"Dime la cantidad de memoria RAM del equipo ({cont}) en GB: ");
                cantRAM = int.Parse(Console.ReadLine());

                Console.Write($"El tamaño del HDD en GB: ");
                tamHDD = int.Parse(Console.ReadLine());

                mediaRAM += cantRAM;
                if (mayorHDD < tamHDD) mayorHDD = tamHDD;

                if (cantRAM < 8)
                    ofimatica++;
                else
                { 
                    if (cantRAM >= 8 && cantRAM <= 16)
                    {
                        if (tamHDD < 256)
                            ofimatica++;
                        else if (tamHDD >= 256 && tamHDD <= 512)
                            programacion++;
                        else
                            disenyo3d++;
                    }
                    else
                        disenyo3d++;
                }


                cont++;

            }

            mediaRAM /= numEquipos;

            Console.WriteLine($"Media de RAM (GB): {Math.Round(mediaRAM,2)}");
            Console.WriteLine("Tamaño HDD más grande: " + mayorHDD);
            Console.WriteLine($"Equipos ofimática = {ofimatica}, Equipos programación = {programacion}, y Esquipos diseño 3D = {disenyo3d}");
        }
    }
}

