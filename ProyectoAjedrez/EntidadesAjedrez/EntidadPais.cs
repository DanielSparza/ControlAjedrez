using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAjedrez
{
    public class EntidadPais
    {
        public int IdPais { get; set; }
        public string Nombre { get; set; }
        public int NClubes { get; set; }

        public EntidadPais(int idpais, string nombre, int nclubes)
        {
            IdPais = idpais;
            Nombre = nombre;
            NClubes = nclubes;
        }
    }
}
