/* Confeccionar un método que reciba por referencia (ref) tres enteros y nos los retorne
en forma ordenada de menor a mayor. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_1
{
    class Program
    {
        // int[] numeros = new int[3];
        static int num1 = 3, num2 = 2 , num3 = 1, temp;

        static void ordenaNum( ref int numA, ref int numB, ref int numC)
        {
            if (num1 > num2 && num1 > num3)
            {
                temp = num1;
                num1 = num3;
                num3 = temp;
            }
            else if (num2 > num1 && num2 > num3 )
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }

            if (num1 > num2)
            {
                temp = num1;
                num1 = num3;
                num3 = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Veamos algunos números... " + num1 + ", " + num2 + ", " + num3);
            ordenaNum(ref num1, ref num2, ref num3);
            Console.WriteLine("Pero los prefiero así... " + num1 + ", " + num2 + ", " + num3);
        }
    }
}
