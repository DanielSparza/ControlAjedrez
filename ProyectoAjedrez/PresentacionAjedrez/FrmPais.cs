using System;
using System.Windows.Forms;
using ManejadorAjedrez;
using EntidadesAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmPais : Form
    {
        ManejadorPais mp;
        EntidadPais ep = new EntidadPais(0, "", 0);
        int fila;

        public FrmPais()
        {
            InitializeComponent();
            mp = new ManejadorPais();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            cargarDatos("");
        }

        public void cargarDatos(string busqueda)
        {
            dtgPais.DataSource = mp.mostrarProductos(busqueda).Tables[0];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPaisAdd pa = new FrmPaisAdd();
            pa.ShowDialog();
            cargarDatos("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatos(txtBuscar.Text);
        }

        private void dtgPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;

                ep.IdPais = int.Parse(dtgPais.Rows[fila].Cells[0].Value.ToString());
                ep.Nombre = dtgPais.Rows[fila].Cells[1].Value.ToString();
                ep.NClubes = int.Parse(dtgPais.Rows[fila].Cells[2].Value.ToString());
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
            if (int.Parse(ep.IdPais.ToString()) > 0)
            {
                DialogResult rs = MessageBox.Show("¿Esta seguro de que desea borrar el país " + ep.Nombre + "?", "!ATENCIÓN¡", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    mp.eliminarPais(ep);
                    cargarDatos("");
                    ep.IdPais = 0;
                }
            }
            else
            {
                MessageBox.Show("Seleccione alguna fila para borrar");
            }
        }

        private void btnActuaizar_Click(object sender, EventArgs e)
        {
            if (int.Parse(ep.IdPais.ToString()) > 0)
            {
                FrmPaisAdd pa = new FrmPaisAdd(ep);
                pa.ShowDialog();
                cargarDatos("");
                ep.IdPais = 0;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar");
            }
        }
    }
}
