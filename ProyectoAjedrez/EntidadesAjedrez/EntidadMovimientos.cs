using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAjedrez
{
    public class EntidadMovimientos
    {
        public string FkPartida { get; set; }
        public int Numero { get; set; }
        public string Blancas { get; set; }
        public string Negras { get; set; }
        public string Comentario { get; set; }

        public EntidadMovimientos(string fkpartida, int numero, string blancas, string negras, string comentario)
        {
            FkPartida = fkpartida;
            Numero = numero;
            Blancas = blancas;
            Negras = negras;
            Comentario = comentario;
        }
    }
}
