using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_1
{
    class Persona
    {
        private string dni;
        private string nombre;
        private string apellidos;
        private int edad;

        public Persona()
        {
            this.dni = string.Empty;
            this.nombre = string.Empty;
            this.apellidos = string.Empty;
            this.edad = 0;
        }

        public Persona(string dni, string nombre, string apellidos, int edad)
        {
            Dni = dni;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            return "DNI: " + dni + "\nNombre: " + nombre + "\nApellidos: " + apellidos + "\nEdad: " + edad;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Persona p = (Persona)obj;
                return dni == p.dni && nombre == p.nombre && apellidos == p.apellidos && edad == p.edad;
            }
        }

        public bool esMayorEdad()
        {
            return edad >= 18;
        }

        public bool esJubilado()
        {
            return edad >= 65;
        }

        public int diferenciaEdad(Persona p)
        {
            return this.edad - p.edad;
        }

        public static bool validarDNI(string dni)
        {
            char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            bool ok = false;
            int numero;
            char letraDNI;
            char letra;

            dni = dni.Trim();

            if (dni.Length == 9 && char.IsDigit(dni[0]) && char.IsDigit(dni[1]) && char.IsDigit(dni[2])
                                && char.IsDigit(dni[3]) && char.IsDigit(dni[4]) && char.IsDigit(dni[5])
                                && char.IsDigit(dni[6]) && char.IsDigit(dni[7]) && char.IsLetter(dni[8]))
            {
                numero = int.Parse(dni.Remove(8, dni.Length - 8));
                letraDNI = letrasDNI[numero % 23];
                letra = char.ToUpper(dni[8]);

                if (letra == letraDNI)
                {
                    ok = true;
                }

            }

            return ok;
        }
    }
}
