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
    public partial class FrmJugadores : Form
    {
        ManejadorJugadores mj;
        EntidadPersonas ep = new EntidadPersonas("", "", "", "", "", "", "");
        EntidadJugadores ej = new EntidadJugadores("", "");
        int fila = 0;
        string r;

        public FrmJugadores()
        {
            InitializeComponent();
            mj = new ManejadorJugadores();
            Actualizar();
        }

        public void Actualizar()
        {
            dgvJugadores.DataSource = mj.Mostrar(txtCodigo.Text).Tables[0];
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal.x = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmJugadoresAdd ja = new FrmJugadoresAdd();
            ja.ShowDialog();
            Actualizar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmJugadoresAdd ja = new FrmJugadoresAdd(ej, ep);
            ja.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show($"¿Estas seguro de borrar los datos?\n\nCodigo: {ep.IdPersona}\nJugador: {ep.Nombre} {ep.Paterno} {ep.Materno}",
                "¡ATENCION!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = mj.Eliminarjugador(ej);
                r = mj.Eliminarpersona(ep);
                Actualizar();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvJugadores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            ep.IdPersona = dgvJugadores.Rows[fila].Cells[0].Value.ToString();
            ej.IdJugador = dgvJugadores.Rows[fila].Cells[0].Value.ToString();
            ep.Nombre = dgvJugadores.Rows[fila].Cells[1].Value.ToString();
            ep.Paterno = dgvJugadores.Rows[fila].Cells[2].Value.ToString();
            ep.Materno = dgvJugadores.Rows[fila].Cells[3].Value.ToString();
            ep.Direccion = dgvJugadores.Rows[fila].Cells[4].Value.ToString();
            ep.Telefono = dgvJugadores.Rows[fila].Cells[5].Value.ToString();
            ep.Pais = dgvJugadores.Rows[fila].Cells[6].Value.ToString();
            ej.Nivel = dgvJugadores.Rows[fila].Cells[7].Value.ToString();
        }
    }
}
