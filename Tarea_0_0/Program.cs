using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_0_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D v1 = new Vector2D();
            Vector2D v2 = new Vector2D(4, 5);
            Console.WriteLine("Contador ---> " + Vector2D.getContador());
            v1.muestraContador();
            v2.muestraContador();
            v1.cambiaContador();
            v1.muestraContador();
            v2.muestraContador();
            Vector2D v3 = new Vector2D(10, 25);
            v1.muestraContador();
        }

    }   

    class Vector2D
    {
        private static int contador;
        double x;
        double y;

        public Vector2D()
        {
            contador++;
            x = 0;
            y = 0;
            
        }

        public Vector2D(double x, double y)
        {
            contador++;
            this.x = x;
            this.y = y;
            
        }

        public void muestraContador()
        {
            Console.WriteLine(contador);
        }

        public void cambiaContador()
        {
            contador = 100;
        }

        public static int getContador()
        {
            return contador;
        }
    }
}
