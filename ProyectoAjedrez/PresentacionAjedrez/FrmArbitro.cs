using System;
using System.Windows.Forms;
using ManejadorAjedrez;
using EntidadesAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmArbitro : Form
    {
        ManejadorArbitro ma;
        EntidadArbitro ea = new EntidadArbitro("", "", "", "", "", "", 0);
        int fila;

        public FrmArbitro()
        {
            InitializeComponent();
            ma = new ManejadorArbitro();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal.x = 0;
        }

        private void FrmArbitro_Load(object sender, EventArgs e)
        {
            cargarDatos("");
        }

        public void cargarDatos(string busqueda)
        {
            dtgArbitro.DataSource = ma.mostrarPersona(busqueda).Tables[0];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmArbitroAdd aa = new FrmArbitroAdd();
            aa.ShowDialog();
            cargarDatos("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatos(txtBuscar.Text);
        }

        private void dtgArbitro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;

                ea.IdArbitro = dtgArbitro.Rows[fila].Cells[0].Value.ToString();
                ea.Nombre = dtgArbitro.Rows[fila].Cells[1].Value.ToString();
                ea.ApPaterno = dtgArbitro.Rows[fila].Cells[2].Value.ToString();
                ea.ApMaterno = dtgArbitro.Rows[fila].Cells[3].Value.ToString();
                ea.Direccion = dtgArbitro.Rows[fila].Cells[4].Value.ToString();
                ea.Telefono = dtgArbitro.Rows[fila].Cells[5].Value.ToString();
                ea.FkPais = ma.obtenerId(dtgArbitro.Rows[fila].Cells[6].Value.ToString());
                
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
            if (ea.IdArbitro.ToString() != "")
            {
                DialogResult rs = MessageBox.Show("¿Esta seguro de que desea borrar el arbitro " + ea.Nombre + " " + ea.ApPaterno + " " + ea.ApMaterno + "?", "!ATENCIÓN¡", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    ma.eliminarArbitro(ea);
                    ma.eliminarCampeonato(ea);
                    ma.eliminarPersona(ea);
                    cargarDatos("");
                    ea.IdArbitro = "";
                }
            }
            else
            {
                MessageBox.Show("Seleccione alguna fila para borrar");
            }
        }

        private void btnActuaizar_Click(object sender, EventArgs e)
        {
            if (ea.IdArbitro.ToString() != "")
            {
                FrmArbitroAdd aa = new FrmArbitroAdd(ea);
                aa.ShowDialog();
                cargarDatos("");
                ea.IdArbitro = "";
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar");
            }
        }
    }
}
