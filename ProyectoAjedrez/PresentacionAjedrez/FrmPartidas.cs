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
    public partial class FrmPartidas : Form
    {
        ManejadorPartidas mp;
        EntidadPartidas ep = new EntidadPartidas("", "", 0, 0, "");
        EntidadColor ec = new EntidadColor("", "", "");
        int fila = 0;
        string r;

        public FrmPartidas()
        {
            InitializeComponent();
            mp = new ManejadorPartidas();
            Actualizar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal.x = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPartidasAdd pa = new FrmPartidasAdd();
            pa.ShowDialog();
            Actualizar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmPartidasAdd pa = new FrmPartidasAdd(ep, ec);
            pa.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show($"¿Estas seguro de borrar los datos?\n\nPartida: {ep.IdPartida}",
                "¡ATENCION!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = mp.Eliminarcolor(ec);
                r = mp.Eliminarpartida(ep);
                Actualizar();
            }
        }

        private void dgvPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            ep.IdPartida = dgvPartidas.Rows[fila].Cells[0].Value.ToString();
            ec.FkPartida = dgvPartidas.Rows[fila].Cells[0].Value.ToString();
            ep.Jornada = dgvPartidas.Rows[fila].Cells[1].Value.ToString();
            ep.Entrada = int.Parse(dgvPartidas.Rows[fila].Cells[2].Value.ToString());
            ep.FkArbitro = dgvPartidas.Rows[fila].Cells[3].Value.ToString();

            ep.FkSala = int.Parse(dgvPartidas.Rows[fila].Cells[4].Value.ToString());

            ec.FkJugador = dgvPartidas.Rows[fila].Cells[6].Value.ToString();
            ec.Color = dgvPartidas.Rows[fila].Cells[10].Value.ToString();
        }

        public void Actualizar()
        {
            dgvPartidas.DataSource = mp.Mostrar(txtPartida.Text).Tables[0];
        }
    }
}
