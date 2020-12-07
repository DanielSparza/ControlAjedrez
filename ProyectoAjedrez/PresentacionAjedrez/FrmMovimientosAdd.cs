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
    public partial class FrmMovimientosAdd : Form
    {
        ManejadorMovimientos mm = new ManejadorMovimientos();
        EntidadMovimientos em = new EntidadMovimientos("", 0, "", "", "");

        public FrmMovimientosAdd()
        {
            InitializeComponent();
        }

        public FrmMovimientosAdd(EntidadMovimientos m)
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtCodigo.Text = m.FkPartida;
            txtNumero.Enabled = false;
            txtNumero.Text = m.Numero.ToString();
            txtBlancas.Text = m.Blancas;
            txtNegras.Text = m.Negras;
            txtComentario.Text = m.Comentario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mm.validarVacio(txtCodigo) && mm.validarVacio(txtNumero) && mm.validarVacio(txtBlancas) && mm.validarVacio(txtNegras) && mm.validarVacio(txtComentario) && mm.validarNumeros(txtNumero))
                {
                    if (txtCodigo.Enabled == true)
                    {
                        string r = mm.Guardarmovimiento(new EntidadMovimientos(txtCodigo.Text, int.Parse(txtNumero.Text), txtBlancas.Text, txtNegras.Text, txtComentario.Text));
                        Close();
                    }
                    else
                    {
                        string r = mm.Actualizarmovimiento(new EntidadMovimientos(txtCodigo.Text, int.Parse(txtNumero.Text), txtBlancas.Text, txtNegras.Text, txtComentario.Text));
                        Close();
                    }
                }
                else if (!mm.validarVacio(txtCodigo))
                {
                    errorProvider.SetError(txtCodigo, "No puede ir vacio código");
                }
                else if (!mm.validarVacio(txtNumero))
                {
                    errorProvider.SetError(txtNumero, "No puede ir vacio número");
                }
                else if (!mm.validarVacio(txtBlancas))
                {
                    errorProvider.SetError(txtBlancas, "No puede ir vacio blancas");
                }
                else if (!mm.validarVacio(txtNegras))
                {
                    errorProvider.SetError(txtNegras, "No puede ir vacio negras");
                }
                else if (!mm.validarVacio(txtComentario))
                {
                    errorProvider.SetError(txtComentario, "No puede ir vacio comentario");
                }
                else if (!mm.validarNumeros(txtNumero))
                {
                    errorProvider.SetError(txtNumero, "No puede ir letras en número");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de dato");
            }
        }
    }
}
