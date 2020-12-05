using System;
using EntidadesAjedrez;
using AccesoADatosAjedrez;
using System.Data;
using System.Windows.Forms;

namespace ManejadorAjedrez
{
    public class ManejadorReservaciones
    {
        ConexionReservacion cr = new ConexionReservacion();
        public string GuardarReservacion(EntidadReservacion r)
        {
            try
            {
                return cr.GuardarReservacion(r);
            }
            catch (Exception)
            {
                return "Error al guardar";
            }
        }
        public string ActualizarReservacion(EntidadReservacion r)
        {
            try
            {
                return cr.ActualizarReservacion(r);
            }
            catch (Exception)
            {
                return "Error al actualizar";
            }
        }
        public string EliminarReservacion(EntidadReservacion r)
        {
            try
            {
                return cr.EliminarReservacion(r);
            }
            catch (Exception)
            {
                return "Error al Eliminar";
            }
        }
        public DataSet MostrarReservaciones(string nombre)
        {
            return cr.MostrarReservacion(nombre);
        }
        public DataSet MostrarPersonas(string idpersona)
        {
            return cr.MostrarPersonas(idpersona);
        }
        public string ObtenerIdPersona(string nombre, string ap, string am)
        {
            DataTable dt = new DataTable();
            dt = cr.ObteneridPersona(nombre, ap, am).Tables[0];
            DataRow r = dt.Rows[0];
            return r["idpersona"].ToString();
        }
        public bool ValidarVacio(TextBox txt)
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
