using System;
using System.Windows.Forms;
using ManejadorAjedrez;
using EntidadesAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmCampeonatos : Form
    {
        ManejadorCampeonato mc;
        EntidadCampeonato ec = new EntidadCampeonato("", 0, "", "");
        int fila;

        public FrmCampeonatos()
        {
            InitializeComponent();
            mc = new ManejadorCampeonato();
        }

        private void FrmCampeonatos_Load(object sender, EventArgs e)
        {
            cargarDatos("");
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal.x = 0;
        }

        public void cargarDatos(string busqueda)
        {
            dtgCampeonatos.DataSource = mc.mostrarCampeonato(busqueda).Tables[0];
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatos(txtBuscar.Text);
        }

        private void dtgCampeonatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;

                ec.FkPersona = mc.mostrarFkPersona(dtgCampeonatos.Rows[fila].Cells[0].Value.ToString());
                ec.IdCampeonato = int.Parse(dtgCampeonatos.Rows[fila].Cells[1].Value.ToString());
                ec.NombreCampeonato = dtgCampeonatos.Rows[fila].Cells[2].Value.ToString();
                ec.Tipo = dtgCampeonatos.Rows[fila].Cells[3].Value.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("La fila seleccionada está vacía.");
            }
            catch (Exception)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ec.IdCampeonato > 0)
            {
                DialogResult rs = MessageBox.Show("¿Esta seguro de que desea borrar el jugador " + dtgCampeonatos.Rows[fila].Cells[0].Value.ToString() + " del campeonato "+ ec.NombreCampeonato +"?", "!ATENCIÓN¡", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    mc.eliminarCampeonato(ec);
                    cargarDatos("");
                    ec.IdCampeonato = 0;
                }
            }
            else
            {
                MessageBox.Show("Seleccione alguna fila para borrar");
            }
        }

        private void btnActuaizar_Click(object sender, EventArgs e)
        {
            if (ec.IdCampeonato > 0)
            {
                FrmCampeonatosAdd ca = new FrmCampeonatosAdd(ec);
                ca.ShowDialog();
                cargarDatos("");
                ec.IdCampeonato = 0;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCampeonatosAdd ca = new FrmCampeonatosAdd();
            ca.ShowDialog();
            cargarDatos("");
        }
    }
}
