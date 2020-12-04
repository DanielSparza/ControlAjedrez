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
        Conectar c = new Conectar("localhost", "root", "", "ajedrez");

        public string guardarArbitro(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("insert into arbitro values('{0}')", arbitro.IdArbitro));
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
            return c.Comando(string.Format("delete from arbitro where IdArbitro = '{0}'", arbitro.IdArbitro));
        }

        public string eliminarPersona(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("delete from personas where IdPersona = '{0}'", arbitro.IdArbitro));
        }

        public string eliminarCampeonato(EntidadArbitro arbitro)
        {
            return c.Comando(string.Format("delete from campeonato where FkPersona = '{0}'", arbitro.IdArbitro));
        }

        public DataSet mostrarArbitro(string busqueda)
        {
            return c.Consultar(string.Format("select p.IdPersona as 'Código', p.Nombre, p.APaterno as 'Ap. Paterno', p.AMaterno as 'Ap. Materno', p.Direccion as Dirección, p.Telefono as Teléfono, c.Nombre as País from personas p, pais c where p.FkPais = c.IdPais and p.Nombre like '%{0}%'",
                busqueda), "personas");
        }

        public DataSet mostrarPais()
        {
            return c.Consultar("select Nombre from pais", "pais");
        }

        public int obtenerIdPais(string pais)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = c.Consultar(string.Format("select IdPais from pais where Nombre = '{0}'",
                    pais), "pais").Tables[0];

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
