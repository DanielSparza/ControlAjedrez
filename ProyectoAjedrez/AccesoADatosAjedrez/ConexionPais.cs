using EntidadesAjedrez;
using System.Data;

namespace AccesoADatosAjedrez
{
    public class ConexionPais
    {
        ConexionBD c = new ConexionBD();

        public string guardarPais(EntidadPais pais)
        {
            return c.Comando(string.Format("insert into paises values(NULL, '{0}', {1})", pais.Nombre, pais.NClubes));
        }

        public string modificarPais(EntidadPais pais)
        {
            return c.Comando(string.Format("update paises set Nombre = '{0}', NClubes = {1} where IdPais = {2}",
                pais.Nombre, pais.NClubes, pais.IdPais));
        }

        public string eliminarPais(EntidadPais pais)
        {
            return c.Comando(string.Format("delete from paises where IdPais = {0}", pais.IdPais));
        }

        public DataSet mostrarPais(string busqueda)
        {
            return c.Mostrar(string.Format("select IdPais as Id, Nombre as País, NClubes as 'No. Clubes' from paises where Nombre like '%{0}%'", busqueda), "paises");
        }
    }
}
