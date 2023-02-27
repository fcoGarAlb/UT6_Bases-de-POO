using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_2
{
    static public class TiposIva
    {
        public const int SUP = 4;
        public const int RED = 10;
        public const int GEN = 21;
    }

    class Articulo
    {
        private static int numeracion;
        private int numero;
        private string nombre;
        private float precio;
        int iva;
        int stock;

        public Articulo(string nombre, float precio, int iva, int stock)
        {
            if (esValidoArticulo(nombre, precio, iva, stock))
            {
                this.numero = ++numeracion;
                Nombre = nombre;
                Precio = precio;
                Iva = iva;
                Stock = stock;
            }
            else
            {
                Console.WriteLine("Los datos introducidos no son validos");
            }

        }

        public Articulo(string nombre, float precio, int stock)
        {
            int iva = 21;

            if (esValidoArticulo(nombre, precio, iva, stock))
            {
                this.numero = ++numeracion;
                Nombre = nombre;
                Precio = precio;
                Iva = iva;
                Stock = stock;
            }
            else
            {
                Console.WriteLine("Los datos introducidos no son validos");
            }
        }

        public int Numero { get => numero; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Iva { get => iva; set => iva = value; }
        public int Stock { get => stock; set => stock = value; }
        

        public override string ToString()
        {
            return "Numero: " + numeracion + "\nNombre: " + nombre + "\nPrecio: " + precio + "\nIva: " + iva + "\nStock: " + stock;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Articulo a = (Articulo)obj;
                return nombre == a.nombre && precio == a.precio && iva == a.iva && stock == a.stock;
            }
        }

        private bool esValidoArticulo(string nombre, float precio, int iva, int stock)
        {
            bool ok = false;

            if (nombre != string.Empty && precio > 0 && (iva == TiposIva.SUP || iva == TiposIva.RED || iva == TiposIva.GEN) && stock > 0)
                ok = true;

            return ok;
        }

        public float getPVP()
        {
            return precio + precio * iva / 100f;
        }

        public float getPVPDescuento(float descuento)
        {
            float PVP = getPVP();

            return PVP - PVP * descuento / 100f;
        }

        public bool vender(int cantidad)
        {
            bool ok = false;

            if (stock >= cantidad)
            {
                stock -= cantidad;
                ok = true;
            }

            return ok;
        }

        public bool almacenar(int cantidad)
        {
            stock += cantidad;
            return true;
        }
    }

    

}
