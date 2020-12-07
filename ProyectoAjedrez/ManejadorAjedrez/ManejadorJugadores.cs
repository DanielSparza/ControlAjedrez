using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAjedrez;
using AccesoADatosAjedrez;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ManejadorAjedrez
{
    public class ManejadorJugadores
    {
        ConexionJugadores cj = new ConexionJugadores();

        public string Guardarjugador(EntidadJugadores ej)
        {
            try
            {
                return cj.GuardarJugador(ej);
            }
            catch (Exception)
            {
                return "Error al Guardar";
            }
        }

        public string Guardarpersona(EntidadPersonas ep)
        {
            try
            {
                return cj.GuardarPersona(ep);
            }
            catch (Exception)
            {
                return "Error al Guardar";
            }
        }

        public string Eliminarjugador(EntidadJugadores ej)
        {
            try
            {
                return cj.EliminarJugador(ej);
            }
            catch (Exception)
            {
                return "Error al Eliminar";
            }
        }

        public string Eliminarpersona(EntidadPersonas ep)
        {
            try
            {
                return cj.EliminarPersona(ep);
            }
            catch (Exception)
            {
                return "Error al Eliminar";
            }
        }

        public string Actualizarjugador(EntidadJugadores ej)
        {
            try
            {
                return cj.ActualizarJugador(ej);
            }
            catch (Exception)
            {
                return "Error al Actualizar los Datos";
            }
        }

        public string Actualizarpersona(EntidadPersonas ep)
        {
            try
            {
                return cj.ActualizarPersona(ep);
            }
            catch (Exception)
            {
                return "Error al Actualizar los Datos";
            }
        }

        public DataSet Mostrar(string nombre)
        {
            return cj.Mostrar(nombre);
        }

        public string obtenerId(string nombre)
        {

            DataTable dt = new DataTable();
            dt = cj.MostrarId(nombre).Tables[0];
            DataRow r = dt.Rows[0];
            return r["IdPersona"].ToString();

        }

        public bool validarNumeros(TextBox txt)
        {
            bool r;
            Match m;
            string numeros = @"\b^[1-9][0-9]*$\b";

            m = Regex.Match(txt.Text, numeros);
            if (m.Success)
            {
                r = true;
            }
            else
            {
                r = false;
            }
            return r;
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

        public void LlenarCombo(ComboBox combo)
        {
            combo.DataSource = cj.mostrarPais().Tables[0];
            combo.DisplayMember = "Nombre";
        }

        public int ObtenerIdPais(string pais)
        {
            DataTable dt = new DataTable();
            dt = cj.obtenerIdPais(pais).Tables[0];
            DataRow r = dt.Rows[0];
            return int.Parse(r["IdPais"].ToString());
        }
    }
}
