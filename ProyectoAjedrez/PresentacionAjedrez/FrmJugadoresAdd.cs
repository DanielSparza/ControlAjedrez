using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAjedrez;
using ManejadorAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmJugadoresAdd : Form
    {
        ManejadorJugadores mj = new ManejadorJugadores();
        EntidadJugadores ej = new EntidadJugadores("", "");
        EntidadPersonas ep = new EntidadPersonas("", "", "", "", "", "", "");
        int indexP, indexN;

        public FrmJugadoresAdd()
        {
            InitializeComponent();
            Llenar();
        }

        public FrmJugadoresAdd(EntidadJugadores j, EntidadPersonas p)
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtCodigo.Text = p.IdPersona;
            txtCodigo.Text = j.IdJugador;
            txtNombre.Text = p.Nombre;
            txtPaterno.Text = p.Paterno;
            txtMaterno.Text = p.Materno;
            txtDireccion.Text = p.Direccion;
            txtTelefono.Text = p.Telefono;
            Llenar();
            indexP = cmbPais.FindString(p.Pais);
            cmbPais.SelectedIndex = indexP;
            indexN = cmbNivel.FindString(j.Nivel);
            cmbNivel.SelectedIndex = indexN;
            ej = j;
            ep = p;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mj.validarVacio(txtCodigo) && mj.validarVacio(txtNombre) && mj.validarVacio(txtPaterno) && mj.validarVacio(txtMaterno) && mj.validarVacio(txtDireccion) && mj.validarVacio(txtTelefono) && mj.validarNumeros(txtTelefono))
                {
                    if (txtCodigo.Enabled == true)
                    {
                        string r = mj.Guardarpersona(new EntidadPersonas(txtCodigo.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtDireccion.Text, txtTelefono.Text, mj.ObtenerIdPais(cmbPais.Text).ToString()));
                        r = mj.Guardarjugador(new EntidadJugadores(txtCodigo.Text, cmbNivel.Text));
                        Close();
                    }
                    else
                    {
                        string r = mj.Actualizarpersona(new EntidadPersonas(txtCodigo.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtDireccion.Text, txtTelefono.Text, mj.ObtenerIdPais(cmbPais.Text).ToString()));
                        r = mj.Actualizarjugador(new EntidadJugadores(txtCodigo.Text, cmbNivel.Text));
                        Close();
                    }
                }
                else if (!mj.validarVacio(txtCodigo))
                {
                    errorProvider.SetError(txtCodigo, "No puede ir vacio código");
                }
                else if (!mj.validarVacio(txtNombre))
                {
                    errorProvider.SetError(txtNombre, "No puede ir vacio nombre");
                }
                else if (!mj.validarVacio(txtPaterno))
                {
                    errorProvider.SetError(txtPaterno, "No puede ir vacio apellido paterno");
                }
                else if (!mj.validarVacio(txtMaterno))
                {
                    errorProvider.SetError(txtMaterno, "No puede ir vacio apellido materno");
                }
                else if (!mj.validarVacio(txtDireccion))
                {
                    errorProvider.SetError(txtDireccion, "No puede ir vacio dirección");
                }
                else if (!mj.validarVacio(txtTelefono))
                {
                    errorProvider.SetError(txtTelefono, "No puede ir vacio teléfono");
                }
                else if (!mj.validarNumeros(txtTelefono))
                {
                    errorProvider.SetError(txtTelefono, "No puede ir letras en teléfono");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de dato");
            }
        }

        public void Llenar()
        {
            cmbNivel.Items.Add("Principiante");
            cmbNivel.Items.Add("Intermedio");
            cmbNivel.Items.Add("Avanzado");

            mj.LlenarCombo(cmbPais);
        }
    }
}
