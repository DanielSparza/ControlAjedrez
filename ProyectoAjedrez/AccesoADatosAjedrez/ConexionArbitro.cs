using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAjedrez;
using Bases;
using System.Data;

namespace AccesoADatosAjedrez
{
    public class ConexionArbitro
    {
        ConexionBD c = new ConexionBD();

        public string guardarArbitro(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("insert into arbitros values('{0}')", arbitro.IdArbitro));
        }

        public string guardarPersona(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("insert into personas values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})",
                arbitro.IdArbitro, arbitro.Nombre, arbitro.ApPaterno, arbitro.ApMaterno, arbitro.Direccion, arbitro.Telefono, arbitro.FkPais));
        }

        public string modificarPersona(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("update personas  set Nombre = '{0}', APaterno = '{1}', AMaterno = '{2}', Direccion = '{3}', Telefono = '{4}', FkPais = {5} where IdPersona = '{6}'",
                arbitro.Nombre, arbitro.ApPaterno, arbitro.ApMaterno, arbitro.Direccion, arbitro.Telefono, arbitro.FkPais, arbitro.IdArbitro));
        }

        public string eliminarArbitro(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("delete from arbitros where IdArbitro = '{0}'", arbitro.IdArbitro));
        }

        public string eliminarPersona(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("delete from personas where IdPersona = '{0}'", arbitro.IdArbitro));
        }

        public string eliminarCampeonato(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("delete from campeonatos where FkPersona = '{0}'", arbitro.IdArbitro));
        }

        public DataSet mostrarArbitro(string busqueda)
        {
            return c.Mostrar(string.Format("select p.IdPersona as 'Código', p.Nombre, p.APaterno as 'Apellido Paterno', p.AMaterno as 'Apellido Materno', p.Direccion as Dirección, p.Telefono as Teléfono, c.Nombre as País from personas p, paises c , arbitros a where p.FkPais = c.IdPais and p.IdPersona = a.IdArbitro and p.Nombre like '%{0}%'",
                busqueda), "personas");
        }

        public DataSet mostrarPais()
        {
            return c.Mostrar("select Nombre from paises", "paises");
        }

        public int obtenerIdPais(string pais)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = c.Mostrar(string.Format("select IdPais from paises where Nombre = '{0}'",
                    pais), "paises").Tables[0];

                DataRow r = dt.Rows[0];
                return int.Parse(r["IdPais"].ToString());
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
    }
}
