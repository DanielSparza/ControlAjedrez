using System;
using System.Windows.Forms;
using EntidadesAjedrez;
using ManejadorAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmAddSala : Form
    {
        ManejadorSalas ms = new ManejadorSalas();
        int id = 0, index;
        public FrmAddSala()
        {
            InitializeComponent();
            LlenarCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ms.ValidarVacio(txtCapacidad) && ms.ValidarVacio(txtMedios))
                {
                    if (id > 0)
                    {
                        string r = ms.ActualizarSala(new EntidadSalas(id, int.Parse(txtCapacidad.Text), txtMedios.Text, ms.ObtenerIdHotel(cmbHotel.Text)));
                        Close();
                    }
                    else
                    {
                        string r = ms.GuardarSala(new EntidadSalas(0, int.Parse(txtCapacidad.Text), txtMedios.Text, ms.ObtenerIdHotel(cmbHotel.Text)));
                        Close();
                    }
                }
                else if(!ms.ValidarVacio(txtCapacidad))
                {
                    errorProvider.SetError(txtCapacidad, "No puede ir vacio capacidad");
                }
                else if(!ms.ValidarVacio(txtMedios))
                {
                    errorProvider.SetError(txtMedios, "No puede ir vacio Medios");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de datos");
            }
        }

        public FrmAddSala(EntidadSalas s, string hotel)
        {
            InitializeComponent();
            id = s.IdSala;
            txtCapacidad.Text = s.Capacidad.ToString();
            txtMedios.Text = s.Medios;
            LlenarCombo();
            index = cmbHotel.FindString(hotel);
            cmbHotel.SelectedIndex = index;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LlenarCombo()
        {
            ms.LlenarCombo(cmbHotel);
        }
    }
}
