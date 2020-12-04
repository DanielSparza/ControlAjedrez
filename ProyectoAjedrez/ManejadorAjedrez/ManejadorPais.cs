using System;
using EntidadesAjedrez;
using AccesoADatosAjedrez;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ManejadorAjedrez
{
    public class ManejadorPais
    {
        ConexionPais cp = new ConexionPais();

        public string guardarPais(EntidadPais pais)
        {
            try
            {
                return cp.guardarPais(pais);
            }
            catch (Exception e)
            {
                return "¡Error, no se guardaron los datos! " + e.Message;
            }
        }

        public string modificarPais(EntidadPais pais)
        {
            try
            {
                return cp.modificarPais(pais);
            }
            catch (Exception e)
            {
                return "¡Error, no se modificaron los datos! " + e.Message;
            }
        }

        public string eliminarPais(EntidadPais pais)
        {
            try
            {
                return cp.eliminarPais(pais);
            }
            catch (Exception e)
            {
                return "¡Error, no se eliminaron los datos! " + e.Message;
            }
        }

        public DataSet mostrarProductos(string busqueda)
        {
            return cp.mostrarPais(busqueda);
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
    }
}
