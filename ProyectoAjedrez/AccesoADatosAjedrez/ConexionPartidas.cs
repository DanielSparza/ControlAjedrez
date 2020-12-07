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
    public class ConexionPartidas
    {
        ConexionBD c = new ConexionBD();

        public string GuardarPartida(EntidadPartidas ep)
        {
            return c.Comando(string.Format("INSERT INTO partidas VALUES('{0}', '{1}', {2}, {3}, '{4}')",
                ep.IdPartida, ep.Jornada, ep.Entrada, ep.FkSala, ep.FkArbitro));
        }

        public string GuardarColor(EntidadColor ec)
        {
            return c.Comando(string.Format("INSERT INTO piezas VALUES('{0}', '{1}', '{2}')",
                ec.FkPartida, ec.FkJugador, ec.Color));
        }

        public string EliminarPartida(EntidadPartidas ep)
        {
            return c.Comando(string.Format("DELETE FROM partidas WHERE IdPartida = '{0}'", ep.IdPartida));
        }

        public string EliminarColor(EntidadColor ec)
        {
            return c.Comando(string.Format("DELETE FROM piezas WHERE FkPartida = '{0}'", ec.FkPartida));
        }

        public string ActualizarPartida(EntidadPartidas ep)
        {
            return c.Comando(string.Format("UPDATE partidas SET Jornada = '{0}', Entrada = '{1}', FkSala = '{2}', FkArbitro = '{3}' WHERE IdPartida = '{4}'",
                ep.Jornada, ep.Entrada, ep.FkSala, ep.FkArbitro, ep.IdPartida));
        }

        public string ActualizarColor(EntidadColor ec)
        {
            return c.Comando(string.Format("UPDATE piezas SET FkJugador = '{0}', Color = '{1}' WHERE FkPartida = '{2}'",
                ec.FkJugador, ec.Color, ec.FkPartida));
        }

        public DataSet Mostrar(string partida)
        {
            //return c.Mostrar(string.Format("SELECT pa.IdPartida AS Partida, pa.Jornada, pa.Entrada, pa.FkSala AS Sala, pa.FkArbitro AS Arbitro, pi.FkJugador AS Jugador, pi.Color FROM partidas pa, piezas pi WHERE IdPartida LIKE '%{0}%'", partida), "partidas");
            return c.Mostrar(string.Format("SELECT pa.Idpartida AS 'Partida', pa.Jornada, pa.Entrada, pa.fkarbitro AS 'Codigo Arbitro',(SELECT p.nombre FROM personas p, arbitros a, partidas pa where a.idarbitro = p.idpersona AND a.idarbitro = pa.fkarbitro) AS 'Arbitro', Pa.fkSala AS 'Sala', H.Nombre AS 'Nombre Hotel', p.idpersona AS 'Codigo Jugador', p.Nombre AS 'Nombre Jugador', p.Apaterno AS 'Apellido Paterno', p.Amaterno AS 'Apellido Materno', pie.Color FROM partidas pa, personas p, piezas pie, jugadores j, salas s, hoteles h WHERE pa.IdPartida = pie.FkPartida AND pie.FkJugador = j.IdJugador AND j.idjugador = p.idpersona AND pa.fksala = s.IdSala AND s.FkHotel = h.IdHotel AND IdPartida LIKE '%{0}%'", partida), "partida");
        }

        public DataSet MostrarId(string partida)
        {
            return c.Mostrar(string.Format("SELECT IdPartida FROM partidas WHERE IdPartida = '{0}'", partida), "partidas");
        }

        public DataSet MostrarIdjugador(string partida, string color)
        {
            return c.Mostrar(string.Format("SELECT FkJugador FROM piezas WHERE FkPartida = '{0}' and Color != '{1}'", partida, color), "partidas");
        }
    }
}
