using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAjedrez
{
    public class EntidadPartidas
    {
        public string IdPartida { get; set; }
        public string Jornada { get; set; }
        public int Entrada { get; set; }
        public int FkSala { get; set; }
        public string FkArbitro { get; set; }

        public EntidadPartidas(string idpartida, string jornada, int entrada, int fksala, string fkarbitro)
        {
            IdPartida = idpartida;
            Jornada = jornada;
            Entrada = entrada;
            FkSala = fksala;
            FkArbitro = fkarbitro;
        }
    }
}
