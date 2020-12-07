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
    public class ManejadorMovimientos
    {
        ConexionMovimientos cm = new ConexionMovimientos();

        public string Guardarmovimiento(EntidadMovimientos em)
        {
            try
            {
                return cm.GuardarMovimiento(em);
            }
            catch (Exception)
            {
                return "Error al Guardar";
            }
        }

        public string Eliminarmovimiento(EntidadMovimientos em)
        {
            try
            {
                return cm.EliminarMovimiento(em);
            }
            catch (Exception)
            {
                return "Error al Eliminar";
            }
        }

        public string Actualizarmovimiento(EntidadMovimientos em)
        {
            try
            {
                return cm.ActualizarMovimiento(em);
            }
            catch (Exception)
            {
                return "Error al Actualizar los Datos";
            }
        }

        public DataSet Mostrar(string partida)
        {
            return cm.Mostrar(partida);
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
    }
}
