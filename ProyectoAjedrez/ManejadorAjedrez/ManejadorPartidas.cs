using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAjedrez;
using AccesoADatosAjedrez;
using System.Data;
using System.Windows.Forms;

namespace ManejadorAjedrez
{
    public class ManejadorPartidas
    {
        ConexionPartidas cp = new ConexionPartidas();

        public string Guardarpartida(EntidadPartidas ep)
        {
            try
            {
                return cp.GuardarPartida(ep);
            }
            catch (Exception)
            {
                return "Error al Guardar";
            }
        }

        public string Guardarcolor(EntidadColor ec)
        {
            try
            {
                return cp.GuardarColor(ec);
            }
            catch (Exception)
            {
                return "Error al Guardar";
            }
        }

        public string Eliminarpartida(EntidadPartidas ep)
        {
            try
            {
                return cp.EliminarPartida(ep);
            }
            catch (Exception)
            {
                return "Error al Eliminar";
            }
        }


        public string Eliminarcolor(EntidadColor ec)
        {
            try
            {
                return cp.EliminarColor(ec);
            }
            catch (Exception)
            {
                return "Error al Eliminar";
            }
        }

        public string Actualizarpartida(EntidadPartidas ep)
        {
            try
            {
                return cp.ActualizarPartida(ep);
            }
            catch (Exception)
            {
                return "Error al Actualizar los Datos";
            }
        }

        public string Actualizarcolor(EntidadColor ec)
        {
            try
            {
                return cp.ActualizarColor(ec);
            }
            catch (Exception)
            {
                return "Error al Actualizar los Datos";
            }
        }

        public DataSet Mostrar(string partida)
        {
            return cp.Mostrar(partida);
        }

        public string obtenerId(string partida)
        {

            DataTable dt = new DataTable();
            dt = cp.MostrarId(partida).Tables[0];
            DataRow r = dt.Rows[0];
            return r["IdPartida"].ToString();

        }

        public string ObtenerIdJugador(string partida, string color)
        {
            DataTable dt = new DataTable();
            dt = cp.MostrarIdjugador(partida, color).Tables[0];
            DataRow r = dt.Rows[0];
            return r["FkJugador"].ToString();
        }

        public bool validarVacio(TextBox txt)
        {
            bool r;

            if (txt.Text.Length == 0 || txt.Text == null)
            {
                r = false;
            }
            else
            {
                r = true;
            }
            return r;
        }
    }
}
