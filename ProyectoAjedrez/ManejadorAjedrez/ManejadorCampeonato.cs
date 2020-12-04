using System;
using EntidadesAjedrez;
using AccesoADatosAjedrez;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ManejadorAjedrez
{
    public class ManejadorCampeonato
    {
        ConexionCampeonato cc = new ConexionCampeonato();

        public string guardarCampeonato(EntidadCampeonato campeonato)
        {
            try
            {
                return cc.guardarCampeonato(campeonato); 
            }
            catch (Exception e)
            {
                return "¡Error, no se guardaron los datos! " + e.Message;
            }
        }

        public string modificarCampeonato(EntidadCampeonato campeonato)
        {
            try
            {
                return cc.modificarCampeonato(campeonato); 
            }
            catch (Exception e)
            {
                return "¡Error, no se modificaron los datos! " + e.Message;
            }
        }

        public string eliminarCampeonato(EntidadCampeonato campeonato)
        {
            try
            {
                return cc.eliminarCampeonato(campeonato); 
            }
            catch (Exception e)
            {
                return "¡Error, no se eliminaron los datos! " + e.Message;
            }
        }

        public DataSet mostrarCampeonato(string busqueda)
        {
            return cc.mostrarCampeonato(busqueda); 
        }

        public DataSet mostrarPerona(string busqueda)
        {
            return cc.mostrarPersona(busqueda); 
        }

        public string mostrarFkPersona(string nombre)
        {
            return cc.obtenerIdPersona(nombre);
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
