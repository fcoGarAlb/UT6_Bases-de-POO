using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_4
{
    enum Estado { descansando = 0, caminando };
    class Zombie
    {
        Estado estado;

        public Zombie()
        {
            estado = 0;
        }

        public void cambiaEstado()
        {
            if (estado == Estado.caminando)
                estado = Estado.descansando;
            else
                estado = Estado.caminando;
        }

        public override string ToString()
        {
            return "El muerto esta " + estado;
        }
    }
}
