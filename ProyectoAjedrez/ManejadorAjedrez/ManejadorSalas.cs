using System;
using EntidadesAjedrez;
using AccesoADatosAjedrez;
using System.Windows.Forms;
using System.Data;

namespace ManejadorAjedrez
{
    public class ManejadorSalas
    {
        ConexionSalas cs = new ConexionSalas();
        public string GuardarSala(EntidadSalas s)
        {
            try
            {
                return cs.GuardarSala(s);
            }
            catch (Exception)
            {
                return "Error al guardar";
            }

        }

        public string ActualizarSala(EntidadSalas s)
        {
            try
            {
                return cs.ActualizarSala(s);
            }
            catch (Exception)
            {
                return "Error al Actualizar";
            }

        }

        public string EliminarSala(EntidadSalas s)
        {
            try
            {
                return cs.EliminarSala(s);
            }
            catch (Exception)
            {
                return "Error Al Eliminar";
            }

        }

        public DataSet Mostrar(string nombre)
        {
            return cs.Mostrar(nombre);
        }

        public void LlenarCombo(ComboBox combo)
        {
            combo.DataSource = cs.ObtenerHotel().Tables[0];
            combo.DisplayMember = "Nombre";
        }
        public int ObtenerIdHotel(string nombre)
        {
            DataTable dt = new DataTable();
            dt = cs.ObtenerIdHotel(nombre).Tables[0];
            DataRow r = dt.Rows[0];
            return int.Parse(r["idhotel"].ToString());
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
