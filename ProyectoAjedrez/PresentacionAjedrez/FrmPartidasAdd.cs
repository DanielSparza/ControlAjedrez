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
    public partial class FrmPartidasAdd : Form
    {
        ManejadorPartidas mp = new ManejadorPartidas();
        EntidadPartidas ep = new EntidadPartidas("", "", 0, 0, "");
        EntidadColor ec = new EntidadColor("", "", "");

        ManejadorJugadores mj = new ManejadorJugadores();
        ManejadorArbitro ma = new ManejadorArbitro();

        public FrmPartidasAdd()
        {
            InitializeComponent();
            Actualizar();
        }

        public FrmPartidasAdd(EntidadPartidas p, EntidadColor c)
        {
            InitializeComponent();
            txtPartida.Enabled = false;
            txtPartida.Text = p.IdPartida;
            dtpJornada.Text = p.Jornada;
            txtEntradas.Text = p.Entrada.ToString();
            txtSala.Text = p.FkSala.ToString();
            txtArbitro.Text = p.FkArbitro;

            if (c.Color == "Blancas")
            {
                txtBlancas.Text = c.FkJugador;
                txtNegras.Text = mp.ObtenerIdJugador(p.IdPartida, "Blancas");
            }
            if (c.Color == "Negras")
            {
                txtNegras.Text = c.FkJugador;
                txtBlancas.Text = mp.ObtenerIdJugador(p.IdPartida, "Negras");
            }

            Actualizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mp.validarVacio(txtPartida) && mp.validarVacio(txtEntradas) && mp.validarVacio(txtArbitro) && mp.validarVacio(txtSala) && mp.validarVacio(txtBlancas) && mp.validarVacio(txtNegras))
                {
                    if (txtPartida.Enabled == true)
                    {
                        string r = mp.Guardarpartida(new EntidadPartidas(txtPartida.Text, dtpJornada.Text, int.Parse(txtEntradas.Text), int.Parse(txtSala.Text), txtArbitro.Text));
                        r = mp.Guardarcolor(new EntidadColor(txtPartida.Text, txtBlancas.Text, "Blancas"));
                        r = mp.Guardarcolor(new EntidadColor(txtPartida.Text, txtNegras.Text, "Negras"));
                        Close();
                    }
                    else
                    {
                        string r = mp.Actualizarpartida(new EntidadPartidas(txtPartida.Text, dtpJornada.Text, int.Parse(txtEntradas.Text), int.Parse(txtSala.Text), txtArbitro.Text));
                        r = mp.Actualizarcolor(new EntidadColor(txtPartida.Text, txtBlancas.Text, "Blancas"));
                        r = mp.Actualizarcolor(new EntidadColor(txtPartida.Text, txtNegras.Text, "Negras"));
                        Close();
                    }
                }
                else if (!mp.validarVacio(txtPartida))
                {
                    errorProvider.SetError(txtPartida, "No puede ir vacio partida");
                }
                else if (!mp.validarVacio(txtEntradas))
                {
                    errorProvider.SetError(txtEntradas, "No puede ir vacio entradas");
                }
                else if (!mp.validarVacio(txtArbitro))
                {
                    errorProvider.SetError(txtArbitro, "No puede ir vacio arbitro");
                }
                else if (!mp.validarVacio(txtSala))
                {
                    errorProvider.SetError(txtSala, "No puede ir vacio sala");
                }
                else if (!mp.validarVacio(txtBlancas))
                {
                    errorProvider.SetError(txtBlancas, "No puede ir vacio blancas");
                }
                else if (!mp.validarVacio(txtNegras))
                {
                    errorProvider.SetError(txtNegras, "No puede ir vacio negras");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de dato");
            }
        }

        public void Actualizar()
        {
            dgvJugadores.DataSource = mj.Mostrar(txtJugador.Text).Tables[0];
            dgvArbitro.DataSource = ma.mostrarPersona(txtBuscarArbitro.Text).Tables[0];
        }

        private void txtJugador_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscarArbitro_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
