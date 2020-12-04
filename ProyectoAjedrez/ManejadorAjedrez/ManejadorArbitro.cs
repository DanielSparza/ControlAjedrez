using System;
using EntidadesAjedrez;
using AccesoADatosAjedrez;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace ManejadorAjedrez
{
    public class ManejadorArbitro
    {
        ConexionArbitro ca = new ConexionArbitro();

        public string guardarArbitro(EntidadArbitro arbitro)
        {
            try
            {
                return ca.guardarArbitro(arbitro);
            }
            catch (Exception e)
            {
                return "¡Error, no se guardaron los datos! " + e.Message;
            }
        }

        public string guardarPersona(EntidadArbitro arbitro)
        {
            try
            {
                return ca.guardarPersona(arbitro);
            }
            catch (Exception e)
            {
                return "¡Error, no se guardaron los datos! " + e.Message;
            }
        }

        public string modificarPersona(EntidadArbitro arbitro)
        {
            try
            {
                return ca.modificarPersona(arbitro); 
            }
            catch (Exception e)
            {
                return "¡Error, no se modificaron los datos! " + e.Message;
            }
        }

        public string eliminarArbitro(EntidadArbitro arbitro)
        {
            try
            {
                return ca.eliminarArbitro(arbitro); 
            }
            catch (Exception e)
            {
                return "¡Error, no se eliminaron los datos! " + e.Message;
            }
        }

        public string eliminarPersona(EntidadArbitro arbitro)
        {
            try
            {
                return ca.eliminarPersona(arbitro);
            }
            catch (Exception e)
            {
                return "¡Error, no se eliminaron los datos! " + e.Message;
            }
        }

        public string eliminarCampeonato(EntidadArbitro arbitro)
        {
            try
            {
                return ca.eliminarCampeonato(arbitro);
            }
            catch (Exception e)
            {
                return "¡Error, no se eliminaron los datos! " + e.Message;
            }
        }

        public DataSet mostrarPersona(string busqueda)
        {
            return ca.mostrarArbitro(busqueda); 
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

        public int obtenerId(string pais)
        {
            return ca.obtenerIdPais(pais);
        }

        public void llenarCombobox(ComboBox cmb)
        {
            cmb.DataSource = ca.mostrarPais().Tables[0]; 
            cmb.DisplayMember = "Nombre";
        }
    }
}
