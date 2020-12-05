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
    public partial class FrmHotel : Form
    {
        EntidadHoteles h = new EntidadHoteles(0, "", "", "");
        ManejadorHoteles mh;
        int fila = 0;
        string r;
        public FrmHotel()
        {
            InitializeComponent();
            mh = new ManejadorHoteles();
            Actualizar();
        }
        public void Actualizar()
        {
            dgvHoteles.DataSource = mh.Mostrar(txtNombre.Text).Tables[0];
        }
        public void Nuevo()
        {
            FrmAddHoteles an = new FrmAddHoteles();
            an.ShowDialog();
            Actualizar();
        }
        public void ActualizarHotel()
        {
            FrmAddHoteles an = new FrmAddHoteles(h);
            an.ShowDialog();
            Actualizar();
        }
        public void GenerarDatos(int fila)
        {
            h.IdHotel = int.Parse(dgvHoteles.Rows[fila].Cells[0].Value.ToString());
            h.Nombre = dgvHoteles.Rows[fila].Cells[1].Value.ToString();
            h.Direccion = dgvHoteles.Rows[fila].Cells[2].Value.ToString();
            h.Telefono = dgvHoteles.Rows[fila].Cells[3].Value.ToString();
        }
        public void Eliminar()
        {
            DialogResult rs = MessageBox.Show("!Atención Estas seguro de eliminar el hotel " + h.Nombre, "!Atencion", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = mh.EliminarHotel(h);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!h.IdHotel.ToString().Equals(""))
            {
                ActualizarHotel();
            }
            else
            {
                MessageBox.Show("Seleccione un fila para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

       

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            GenerarDatos(fila);
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
