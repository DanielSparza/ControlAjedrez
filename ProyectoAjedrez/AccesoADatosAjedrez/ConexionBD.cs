using Bases;
using System.Data;

namespace AccesoADatosAjedrez
{
    public class ConexionBD
    {
        Conectar c = new Conectar("localhost", "root", "", "Ajedrez");
        public string Comando(string q)
        {
            return c.Comando(q);
        }
        public DataSet Mostrar(string q, string tabla)
        {
            return c.Consultar(q, tabla);
        }
    }
}
