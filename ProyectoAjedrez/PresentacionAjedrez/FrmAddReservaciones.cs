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
    public partial class FrmAddReservaciones : Form
    {
        ManejadorReservaciones mr = new ManejadorReservaciones();
        ManejadorSalas ms = new ManejadorSalas();
        int id = 0, index, fila;
        string idpersona;
        public FrmAddReservaciones()
        {
            InitializeComponent();
            LlenarCombo();
            Actualizar();
        }
        public FrmAddReservaciones(EntidadReservacion r, string nombre, string ap, string am, string hotel)
        {
            InitializeComponent();
            Actualizar();
            LlenarCombo();
            id = r.IdReservacion;
            idpersona = mr.ObtenerIdPersona(nombre, ap, am);
            txtParticipante.Text = nombre + " " + ap + " " + am;
            dtpFechaEntrada.Text = r.FechaEntrada;
            dtpFechaSalida.Text = r.FechaSalida;
            index = cmbHotel.FindString(hotel);
            cmbHotel.SelectedIndex = index;

        }
        public void Actualizar()
        {
            dgvParticipantes.DataSource = mr.MostrarPersonas(txtCodigo.Text).Tables[0];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mr.ValidarVacio(txtParticipante))
                {
                    if (id > 0)
                    {
                        string r = mr.ActualizarReservacion(new EntidadReservacion(id, dtpFechaEntrada.Text, dtpFechaSalida.Text, ms.ObtenerIdHotel(cmbHotel.Text), idpersona));
                        Close();
                    }
                    else if (!txtParticipante.Text.Equals(""))
                    {
                        string r = mr.GuardarReservacion(new EntidadReservacion(0, dtpFechaEntrada.Text, dtpFechaSalida.Text, ms.ObtenerIdHotel(cmbHotel.Text), idpersona));
                        Close();
                    }
                }
                else
                {
                    errorProvider.SetError(txtParticipante, "No puede estar el campo vacio");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de dato");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpFechaEntrada_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaSalida.Enabled = true;
            dtpFechaSalida.MinDate = dtpFechaEntrada.Value;
            dtpFechaSalida.Value = dtpFechaEntrada.Value;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            GenerarDatosPersona(fila);
        }

        public void GenerarDatosPersona(int fila)
        {
            idpersona = dgvParticipantes.Rows[fila].Cells[0].Value.ToString();
            string nombre = dgvParticipantes.Rows[fila].Cells[1].Value.ToString();
            string ap = dgvParticipantes.Rows[fila].Cells[2].Value.ToString();
            string am = dgvParticipantes.Rows[fila].Cells[3].Value.ToString();
            txtParticipante.Text = nombre + " " + ap + " " + am;
        }
        public void LlenarCombo()
        {
            ms.LlenarCombo(cmbHotel);
        }
    }
}
