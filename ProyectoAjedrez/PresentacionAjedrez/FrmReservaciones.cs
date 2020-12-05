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
    public partial class FrmReservaciones : Form
    {
        ManejadorReservaciones mr;
        ManejadorSalas ms;
        EntidadReservacion r = new EntidadReservacion(0, "", "", 0, "");
        string re, Nombre, Ap, Am, Hotel;
        int fila;
        public FrmReservaciones()
        {
            InitializeComponent();
            mr = new ManejadorReservaciones();
            ms = new ManejadorSalas();
            Actualizar();
        }
        public void Actualizar()
        {
            dgvReservaciones.DataSource = mr.MostrarReservaciones(txtNombre.Text).Tables[0];
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!r.IdReservacion.ToString().Equals(""))
                ActualizarDatos();
            else
                MessageBox.Show("Seleccione una fila para modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dgvReservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            GenerarDatos(fila);
        }

        public void GenerarDatos(int fila)
        {
            r.IdReservacion = int.Parse(dgvReservaciones.Rows[fila].Cells[0].Value.ToString());
            r.FechaEntrada = dgvReservaciones.Rows[fila].Cells[1].Value.ToString();
            r.FechaSalida = dgvReservaciones.Rows[fila].Cells[2].Value.ToString();
            r.FkIdHotel = ms.ObtenerIdHotel(dgvReservaciones.Rows[fila].Cells[3].Value.ToString());
            Hotel = dgvReservaciones.Rows[fila].Cells[3].Value.ToString();
            Nombre = dgvReservaciones.Rows[fila].Cells[4].Value.ToString();
            Ap = dgvReservaciones.Rows[fila].Cells[5].Value.ToString();
            Am = dgvReservaciones.Rows[fila].Cells[6].Value.ToString();
            r.FkIdPersona = mr.ObtenerIdPersona(Nombre, Ap, Am);
        }
        public void ActualizarDatos()
        {
            FrmAddReservaciones far = new FrmAddReservaciones(r, Nombre, Ap, Am, Hotel);
            far.ShowDialog();
            Actualizar();
        }
        public void Eliminar()
        {
            DialogResult rs = MessageBox.Show("!Atención Estas seguro de eliminar la reservacion de " + Nombre + " " + Ap + " " + Am + " en el hotel " + Hotel, "!Atencion", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                re = mr.EliminarReservacion(r);
            }
            Actualizar();
        }
        public void Nuevo()
        {
            FrmAddReservaciones far = new FrmAddReservaciones();
            far.ShowDialog();
            Actualizar();
        }
    }
}
