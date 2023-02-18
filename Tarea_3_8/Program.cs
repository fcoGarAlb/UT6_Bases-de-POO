/* Crea una aplicación que solicite al usuario una serie de precios de productos y el IVA
a aplicar (superreducido del 4%,reducido del 10%, general del 21% ). Crea un
método que dado un precio y el tipo de IVA te devuelva el precio con IVA. Este
precio se le mostrará al cliente. El usuario estará continuamente introduciendo
precios de productos hasta que te introduzca -1 como precio de producto. Al
finalizar, aplica un descuento al total de todos los productos del 5% si ha introducido
más de 3 productos y del 10% si ha introducido más de 5. Para el cálculo del
descuento utiliza un método que les pases el total de productos y el precio total. Los
precios que imprimas por pantalla deben ir redondeados con 2 decimales. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seguir = true;
            float precio = 0, precioTotal = 0, precioIva = 0;
            const int ivaSup = 4, ivaRed = 10, ivaGen = 21;
            int numProd = 0;
            char tipoIVA;

            while (seguir)
            {
                Console.Write("Dame el precio de un producto: ");
                precio = float.Parse(Console.ReadLine());
                

                if ( precio == -1)
                    seguir = false;
                else
                {
                    Console.Write("Dime el tipo de IVA [S]upereducido, [R]educido, [G]eneral: ");
                    tipoIVA = char.ToUpper((Console.ReadLine())[0]);
                    switch(tipoIVA)
                    {
                        case 'S': precioIva = CalculaPrecioIva(precio, ivaSup); break;
                        case 'R': precioIva = CalculaPrecioIva(precio, ivaRed); break;
                        case 'G': precioIva = CalculaPrecioIva(precio, ivaGen); break;
                    }

                    Console.WriteLine("El precio de producto con IVA es de " + precioIva.ToString("0.##" ) + "\n");
                    
                    numProd++;
                    precioTotal += precioIva;
                }
            }

            Console.WriteLine($"El importe de tu compra es {(precioTotal - CalculaDescuento(precioTotal, numProd)).ToString("0.##")}" );
        }

        static float CalculaPrecioIva( float precio, int iva )
        { 
            return precio  + (precio  * iva * 0.01f);
        }

        static float CalculaDescuento( float precio, int numProd)
        {
            float descuento = 0;

            if (numProd >= 3 && numProd <= 5)
                descuento = precio * 0.05f;
            else if (numProd > 5)
                    descuento = precio * 0.10f;

            return descuento;
        }

    }
}
