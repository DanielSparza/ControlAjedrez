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
    public class ConexionMovimientos
    {
        ConexionBD c = new ConexionBD();

        public string GuardarMovimiento(EntidadMovimientos em)
        {
            return c.Comando(string.Format("INSERT INTO movimientos VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                em.FkPartida, em.Numero, em.Blancas, em.Negras, em.Comentario));
        }

        public string EliminarMovimiento(EntidadMovimientos em)
        {
            return c.Comando(string.Format("DELETE FROM movimientos WHERE FkPartida = '{0}' AND Numero = {1}", em.FkPartida, em.Numero));
        }

        public string ActualizarMovimiento(EntidadMovimientos em)
        {
            return c.Comando(string.Format("UPDATE movimientos SET Blancas = '{0}', Negras = '{1}', Comentario = '{2}' WHERE FkPartida = '{3}' AND Numero = '{4}'",
                em.Blancas, em.Negras, em.Comentario, em.FkPartida, em.Numero));
        }

        public DataSet Mostrar(string partida)
        {
            return c.Mostrar(string.Format("SELECT * FROM movimientos WHERE FkPartida LIKE '%{0}%'", partida), "partidas");
        }
    }
}
