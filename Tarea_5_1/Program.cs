using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dni, nombre, apellidos;
            int edad;
          
            Console.WriteLine("Dime tu número de DNI: ");
            dni = Console.ReadLine();

            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Y tus apellidos: ");
            apellidos = Console.ReadLine();

            Console.WriteLine("¿Qué edad tienes?");
            edad = int.Parse(Console.ReadLine());

            if (!Persona.validarDNI(dni))
            {
                Console.WriteLine("Parece que has introducido un DNI no valido");
            }
            else
            {
                Persona unaPersona = new Persona(dni, nombre, apellidos, edad);
                Console.WriteLine("Datos introducidos\n" + unaPersona.ToString());
                Console.WriteLine((unaPersona.esMayorEdad())? "Mayor de edad": "Menor de edad");
                Console.WriteLine((unaPersona.esJubilado()) ? "Jubilado" : "No jubilado");
                Console.WriteLine();


                Persona otraPersona = new Persona();
           
                otraPersona.Dni = "12345678H";
                otraPersona.Nombre = "otraPersona";
                otraPersona.Apellidos = "Otros";
                otraPersona.Edad = 16;
                Console.WriteLine("Otra persona creada\n" + otraPersona.ToString());
                Console.WriteLine((otraPersona.esMayorEdad()) ? "Mayor de edad" : "Menor de edad");
                Console.WriteLine((otraPersona.esJubilado()) ? "Jubilado" : "No jubilado");
                Console.WriteLine();

                Console.WriteLine(unaPersona.diferenciaEdad(otraPersona));
                Console.WriteLine($"Comparamos las dos personas: {((unaPersona.Equals(otraPersona))? "Son la misma persona" : "Son personas distintas")}");
                Console.WriteLine($"Comparamos los datos introducidos consigo mismo: {((unaPersona.Equals(unaPersona)) ? "Son la misma persona" : "Son personas distintas")}");
            }

        }
    }
}
