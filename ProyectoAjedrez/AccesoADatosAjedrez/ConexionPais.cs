using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAjedrez;
using System.Data;
using Bases;

namespace AccesoADatosAjedrez
{
    public class ConexionPais
    {
        Conectar c = new Conectar("localhost", "root", "", "ajedrez");

        public string guardarPais(EntidadPais pais)
        {
            return c.Comando(string.Format("insert into pais values(NULL, '{0}', {1})", pais.Nombre, pais.NClubes));
        }

        public string modificarPais(EntidadPais pais)
        {
            return c.Comando(string.Format("update pais set Nombre = '{0}', NClubes = {1} where IdPais = {2}",
                pais.Nombre, pais.NClubes, pais.IdPais));
        }

        public string eliminarPais(EntidadPais pais)
        {
            return c.Comando(string.Format("delete from pais where IdPais = {0}", pais.IdPais));
        }

        public DataSet mostrarPais(string busqueda)
        {
            return c.Consultar(string.Format("select IdPais as Id, Nombre as País, NClubes as 'No. Clubes' from pais where Nombre like '%{0}%'", busqueda), "pais");
        }
    }
}
