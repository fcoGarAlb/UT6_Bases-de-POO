/* Diseña un tipo de dato que represente un zombi. Este tipo debe tener un método
que, al ser invocado, actúa como interruptor:
a. Al invocar a este método, si el muerto está descansando, entonces lo
despierta y muestra por consola al muerto caminando.
b. Al invocar a este método, si el muerto estaba despierto, entonces lo duerme
y muestra al muerto descansando.
c. Desde el main crea un objeto zombi y llama varias veces a este método para
comprobarlo.
d. La clase zombie debe tener algún atributo dónde guardes el estado en el que
se encuentra el zombie, si descansando o caminando. Este dato podría ser
un tipo de dato enumerado. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Zombie nuevo = new Zombie();

            Console.WriteLine(nuevo.ToString());

            nuevo.cambiaEstado();
            Console.WriteLine(nuevo.ToString());

            nuevo.cambiaEstado();
            Console.WriteLine(nuevo.ToString());
        }

    }
}
