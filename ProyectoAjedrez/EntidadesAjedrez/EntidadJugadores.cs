using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAjedrez
{
    public class EntidadJugadores
    {
        public string IdJugador { get; set; }
        public string Nivel { get; set; }

        public EntidadJugadores(string idjugador, string nivel)
        {
            IdJugador = idjugador;
            Nivel = nivel;
        }
    }
}
