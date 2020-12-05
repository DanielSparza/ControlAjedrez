using System;
using EntidadesAjedrez;
using AccesoADatosAjedrez;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ManejadorAjedrez
{
    public class ManejadorHoteles
    {
        ConexionHoteles ch = new ConexionHoteles();
        public string GuardarHotel(EntidadHoteles h)
        {
            try
            {
                return ch.GuardarHotel(h);
            }
            catch (Exception)
            {
                return "Error al guardar";
            }

        }
        public string EliminarHotel(EntidadHoteles h)
        {
            try
            {
                return ch.Eliminar(h);
            }
            catch (Exception)
            {
                return "Error al eliminar";
            }
        }
        public string Actualizar(EntidadHoteles h)
        {
            try
            {
                return ch.Actualizar(h);
            }
            catch (Exception)
            {
                return "Error al actualizar";
            }
        }
        public DataSet Mostrar(string nombre)
        {
            return ch.Mostrar(nombre);
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
        public bool validarNumeros(string fkid)
        {
            bool r;
            Match m;
            string numeros = @"\b^[1-9][0-9]*$\b";

            m = Regex.Match(fkid, numeros);
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
