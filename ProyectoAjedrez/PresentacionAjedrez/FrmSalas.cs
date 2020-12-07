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
    public partial class FrmSalas : Form
    {
        EntidadSalas s = new EntidadSalas(0, 0, "", 0);
        ManejadorSalas ms;
        int fila;
        string r, hotel;
        public FrmSalas()
        {
            InitializeComponent();
            ms = new ManejadorSalas();
            Actualizar();
        }
        public void Actualizar()
        {
            dgvSalas.DataSource = ms.Mostrar(txtNombre.Text).Tables[0];
        }
        public void Nuevo()
        {
            FrmAddSala fas = new FrmAddSala();
            fas.ShowDialog();
            Actualizar();
        }
        public void ELiminar()
        {
            DialogResult rs = MessageBox.Show("!Atención Estas seguro de eliminar la sala " + s.IdSala + " del hotel " + hotel, "!Atencion", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ms.EliminarSala(s);
                Actualizar();
            }
        }
        public void ActualizarDatos()
        {
            FrmAddSala fas = new FrmAddSala(s, hotel);
            fas.ShowDialog();
            Actualizar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!s.IdSala.ToString().Equals(""))
                ActualizarDatos();
            else
                MessageBox.Show("Seleccione una fila para modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ELiminar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            Generardatos(fila);
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal.x = 0;
        }

        public void Generardatos(int fila)
        {
            s.IdSala = int.Parse(dgvSalas.Rows[fila].Cells[0].Value.ToString());
            s.Capacidad = int.Parse(dgvSalas.Rows[fila].Cells[1].Value.ToString());
            s.Medios = dgvSalas.Rows[fila].Cells[2].Value.ToString();
            s.FkIdHotel = ms.ObtenerIdHotel(dgvSalas.Rows[fila].Cells[3].Value.ToString());
            hotel = dgvSalas.Rows[fila].Cells[3].Value.ToString();

        }
    }
}
