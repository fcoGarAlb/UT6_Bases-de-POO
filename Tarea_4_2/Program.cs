/* Solicita al usuario su número de DNI y comprueba si la última letra introducida es
correcta. La letra del DNI es una letra de control que se calcula a partir de los 8
números. Se realiza el módulo 23 a los números y el número dado es un dígito que
se corresponde con una letra:
T → 0
R → 1
W → 2
A → 3
G → 4
M → 5
Y → 6
F → 7
P → 8
D → 9
X → 10
B → 11
N → 12
J → 13
Z → 14
S → 15
Q → 17
V → 17
H → 18
L → 19
C → 20
K → 21
E → 22
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4_2
{
    class Program
    {
        static char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        static void Main(string[] args)
        {
            string dni;
            bool ok = false;

            do
            {

                Console.WriteLine("Dime tu número de DNI y te digo si tu letra es correcta: ");
                dni = Console.ReadLine().Trim();
                if (dni.Length != 9 || !char.IsDigit(dni[0]) || !char.IsDigit(dni[1]) || !char.IsDigit(dni[2])
                                    || !char.IsDigit(dni[3]) || !char.IsDigit(dni[4]) || !char.IsDigit(dni[5])
                                    || !char.IsDigit(dni[6]) || !char.IsDigit(dni[7]) || !char.IsLetter(dni[8]))
                    Console.WriteLine("El DNI no esta bién escrito");
                else
                    ok = true;

            } while (!ok);

            Console.WriteLine($"Tu letra es {((CompruebaLetraDNI(dni))? "correcta" : "incorrecta")}");

        }

        private static bool CompruebaLetraDNI( string dni )
        {
            bool ok = false;
            int numero = int.Parse(dni.Remove(8, dni.Length - 8));
            char letraDNI = letrasDNI[ numero % 23 ];
            char letra =  char.ToUpper(dni[8]);


            if (letra == letraDNI)
                ok = true;

            return ok;
        }
    }
}
