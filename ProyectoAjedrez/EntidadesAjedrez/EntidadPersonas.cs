using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAjedrez
{
    public class EntidadPersonas
    {
        public string IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }

        public EntidadPersonas(string idpersona, string nombre, string paterno, string materno, string direccion, string telefono, string pais)
        {
            IdPersona = idpersona;
            Nombre = nombre;
            Paterno = paterno;
            Materno = materno;
            Direccion = direccion;
            Telefono = telefono;
            Pais = pais;
        }
    }
}
