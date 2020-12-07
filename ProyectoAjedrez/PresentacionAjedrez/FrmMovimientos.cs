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
    public partial class FrmMovimientos : Form
    {
        ManejadorMovimientos mm;
        EntidadMovimientos em = new EntidadMovimientos("", 0, "", "", "");
        int fila = 0;
        string r;

        public FrmMovimientos()
        {
            InitializeComponent();
            mm = new ManejadorMovimientos();
            Actualizar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal.x = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMovimientosAdd ma = new FrmMovimientosAdd();
            ma.ShowDialog();
            Actualizar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmMovimientosAdd ma = new FrmMovimientosAdd(em);
            ma.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show($"¿Estas seguro de borrar los datos?\n\nPartida: {em.FkPartida}\nNumero: {em.Numero}",
                "¡ATENCION!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = mm.Eliminarmovimiento(em);
                Actualizar();
            }
        }

        private void txtPartida_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvMovimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            em.FkPartida = dgvMovimientos.Rows[fila].Cells[0].Value.ToString();
            em.Numero = int.Parse(dgvMovimientos.Rows[fila].Cells[1].Value.ToString());
            em.Blancas = dgvMovimientos.Rows[fila].Cells[2].Value.ToString();
            em.Negras = dgvMovimientos.Rows[fila].Cells[3].Value.ToString();
            em.Comentario = dgvMovimientos.Rows[fila].Cells[4].Value.ToString();
        }

        public void Actualizar()
        {
            dgvMovimientos.DataSource = mm.Mostrar(txtPartida.Text).Tables[0];
        }
    }
}
