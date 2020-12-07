using System;
using EntidadesAjedrez;
using Bases;
using System.Data;

namespace AccesoADatosAjedrez
{
    public class ConexionCampeonato
    {
        ConexionBD c = new ConexionBD();

        public string guardarCampeonato(EntidadCampeonato campeonato)
        {
            return c.Comando(string.Format("insert into campeonatos values('{0}', {1}, '{2}', '{3}')",
                campeonato.FkPersona, campeonato.IdCampeonato, campeonato.NombreCampeonato, campeonato.Tipo));
        }

        public string modificarCampeonato(EntidadCampeonato campeonato)
        {
            return c.Comando(string.Format("update campeonatos set Nombre = '{0}', Tipo = '{1}' where IdCampeonato = {2} and FkPersona = '{3}'",
                campeonato.NombreCampeonato, campeonato.Tipo, campeonato.IdCampeonato, campeonato.FkPersona));
        }

        public string eliminarCampeonato(EntidadCampeonato campeonato)
        {
            return c.Comando(string.Format("delete from campeonatos where IdCampeonato = '{0}' and FkPersona = '{1}'", campeonato.IdCampeonato, campeonato.FkPersona));
        }

        public DataSet mostrarCampeonato(string busqueda)
        {
            return c.Mostrar(string.Format("select p.Nombre as 'Participante', c.IdCampeonato, c.Nombre, c.Tipo from personas p, campeonatos c where c.FkPersona = p.IdPersona and p.Nombre like '%{0}%'",
                busqueda), "campeonatos");
        }

        public DataSet mostrarPersona(string busqueda)
        {
            return c.Mostrar(string.Format("select p.IdPersona as 'Código', p.Nombre, p.APaterno as 'Ap. Paterno', p.AMaterno as 'Ap. Materno', p.Direccion as Dirección, p.Telefono as Teléfono, c.Nombre as País from personas p, paises c where p.FkPais = c.IdPais and p.IdPersona like '%{0}%'",
                busqueda), "personas");
        }

        public string obtenerIdPersona(string persona)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = c.Mostrar(string.Format("select IdPersona from personas where Nombre = '{0}'",
                    persona), "personas").Tables[0];

                DataRow r = dt.Rows[0];
                return r["IdPersona"].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                return "";
            }
        }
    }
}
