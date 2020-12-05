using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorAjedrez;
using EntidadesAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmAddHoteles : Form
    {
        int idhotel = 0;
        ManejadorHoteles mh = new ManejadorHoteles();
        public FrmAddHoteles()
        {
            InitializeComponent();
        }
        public FrmAddHoteles(EntidadHoteles h)
        {
            InitializeComponent();
            idhotel = h.IdHotel;
            txtNombre.Text = h.Nombre;
            txtDireccion.Text = h.Direccion;
            txtTelefono.Text = h.Telefono;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mh.ValidarVacio(txtNombre) && mh.ValidarVacio(txtDireccion) && mh.ValidarVacio(txtTelefono) && mh.validarNumeros(txtTelefono.Text))
                {
                    if (idhotel > 0)
                    {
                        string r = mh.Actualizar(new EntidadHoteles(idhotel, txtNombre.Text, txtDireccion.Text, txtTelefono.Text));
                        Close();
                    }
                    else
                    {
                        string r = mh.GuardarHotel(new EntidadHoteles(0, txtNombre.Text, txtDireccion.Text, txtTelefono.Text));
                        Close();
                    }
                }
                else if (!mh.ValidarVacio(txtNombre))
                {
                    errorProvider.SetError(txtNombre, "No puede ir el nombre vacio");
                }
                else if (!mh.ValidarVacio(txtDireccion))
                {
                    errorProvider.SetError(txtDireccion, "No puede ir la dirreccion vacia");
                }
                else if (!mh.ValidarVacio(txtTelefono))
                {
                    errorProvider.SetError(txtTelefono, "No puede ir el telefono vacio");
                }
                else if (!mh.validarNumeros(txtTelefono.Text))
                {
                    errorProvider.SetError(txtTelefono, "Telefono no valido");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar los datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
