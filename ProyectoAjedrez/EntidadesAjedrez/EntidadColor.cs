using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAjedrez
{
    public class EntidadColor
    {
        public string FkPartida { get; set; }
        public string FkJugador { get; set; }
        public string Color { get; set; }

        public EntidadColor(string fkpartida, string fkjugador, string color)
        {
            FkPartida = fkpartida;
            FkJugador = fkjugador;
            Color = color;
        }
    }
}
