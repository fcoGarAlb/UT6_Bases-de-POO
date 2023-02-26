using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string nombre;
            int iva, cantidad;
            float precio, descuento;


            Console.WriteLine("Dime el nombre del artículo: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Dime precio: ");
            precio = float.Parse(Console.ReadLine());

            Console.WriteLine("Iva: ");
            iva = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            Articulo uno = new Articulo(nombre, precio, iva, cantidad);
            Console.WriteLine(uno.ToString());
            Console.WriteLine(uno.getPVP());
            Console.WriteLine("Dame un descuento: ");
            descuento = float.Parse(Console.ReadLine());
            Console.WriteLine(uno.getPVPDescuento(descuento));

            Console.WriteLine("Dime un numero de articulos a vender: ");
            Console.WriteLine(uno.vender(int.Parse(Console.ReadLine()))? "Articulo/s vendido/s": "Articulo/s no vendido/s");
            Console.WriteLine(uno.ToString());

            Console.WriteLine("Dime un numero de articulos a almacenar: ");
            Console.WriteLine(uno.almacenar(int.Parse(Console.ReadLine()))? "Artículo/s almacenado/s" : "Artículo/s no almacenado/s");
            Console.WriteLine(uno.ToString());


        }
    }
}
