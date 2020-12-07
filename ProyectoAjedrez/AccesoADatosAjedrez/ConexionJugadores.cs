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
    public class ConexionJugadores
    {
        ConexionBD c = new ConexionBD();

        public string GuardarJugador(EntidadJugadores ej)
        {
            return c.Comando(string.Format("INSERT INTO jugadores VALUES('{0}', '{1}')",
                ej.IdJugador, ej.Nivel));

        }

        public string GuardarPersona(EntidadPersonas ep)
        {
            return c.Comando(string.Format("INSERT INTO personas VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                ep.IdPersona, ep.Nombre, ep.Paterno, ep.Materno, ep.Direccion, ep.Telefono, ep.Pais));

        }

        public string EliminarJugador(EntidadJugadores ej)
        {
            return c.Comando(string.Format("DELETE FROM jugadores WHERE IdJugador = '{0}'", ej.IdJugador));
        }

        public string EliminarPersona(EntidadPersonas ep)
        {
            return c.Comando(string.Format("DELETE FROM personas WHERE IdPersona = '{0}'", ep.IdPersona));
        }

        public string ActualizarJugador(EntidadJugadores ej)
        {
            return c.Comando(string.Format("UPDATE jugadores SET Nivel = '{0}' WHERE IdJugador = '{1}'",
                ej.Nivel, ej.IdJugador));
        }

        public string ActualizarPersona(EntidadPersonas ep)
        {
            return c.Comando(string.Format("UPDATE personas SET Nombre = '{0}', APaterno = '{1}', AMaterno = '{2}', Direccion = '{3}', Telefono = '{4}', FkPais = '{5}' WHERE IdPersona = '{6}'",
                ep.Nombre, ep.Paterno, ep.Materno, ep.Direccion, ep.Telefono, ep.Pais, ep.IdPersona));
        }

        public DataSet Mostrar(string nombre)
        {
            return c.Mostrar(string.Format("SELECT p.IdPersona AS Código, p.Nombre, p.APaterno AS 'Apellido Paterno', p.AMaterno AS 'Apellido Materno', p.Direccion AS 'Dirección', p.Telefono AS 'Teléfono', pa.Nombre AS 'País', j.Nivel FROM personas p, jugadores j, paises pa WHERE p.IdPersona = j.IdJugador AND p.FkPais = pa.IdPais AND p.Nombre LIKE '%{0}%'", nombre), "jugadores");
        }

        public DataSet MostrarId(string nombre)
        {
            return c.Mostrar(string.Format("SELECT IdPersona FROM personas WHERE Nombre = '{0}'", nombre), "personas");
        }

        public DataSet mostrarPais()
        {
            return c.Mostrar("SELECT Nombre FROM paises", "paises");
        }

        public DataSet obtenerIdPais(string pais)
        {
            return c.Mostrar(string.Format("SELECT IdPais FROM paises WHERE Nombre = '{0}'", pais), "paises");
        }
    }
}
