using System;
using System.Windows.Forms;
using ManejadorAjedrez;
using EntidadesAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmPaisAdd : Form
    {
        ManejadorPais mp;
        EntidadPais ep = new EntidadPais(0, "", 0);
        int bandera;

        public FrmPaisAdd()
        {
            InitializeComponent();
            mp = new ManejadorPais();
        }

        public FrmPaisAdd(EntidadPais pais)
        {
            InitializeComponent();
            mp = new ManejadorPais();

            txtNombre.Text = pais.Nombre;
            txtNoClubes.Text = pais.NClubes.ToString();
            bandera = pais.IdPais;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mp.validarVacio(txtNombre) && mp.validarVacio(txtNoClubes) && mp.validarNumeros(txtNoClubes))
            {
                if (bandera > 0)
                {
                    modificarPais();
                    MessageBox.Show("El registro se modificó correctamente");
                    limpiarErrores();
                    Close();
                }
                else
                {
                    guardarPais();
                    MessageBox.Show("Registro añadido correctamente");
                    limpiarErrores();
                    Close();
                }
            }
            else if (!mp.validarVacio(txtNombre))
            {
                errorProvider.SetError(txtNombre, "No se puede dejar el campo Nombre vacío");
            }
            else if (!mp.validarVacio(txtNoClubes))
            {
                errorProvider.SetError(txtNoClubes, "No se puede dejar el campo No. Clubes vacío");
            }
            else if (!mp.validarNumeros(txtNoClubes))
            {
                errorProvider.SetError(txtNoClubes, "Solo se permiten caracteres numéricos");
            }
        }

        public void guardarPais()
        {
            ep = new EntidadPais(0, txtNombre.Text, int.Parse(txtNoClubes.Text));
            mp.guardarPais(ep);
            txtNombre.Clear();
            txtNoClubes.Clear();
        }

        public void modificarPais()
        {
            ep = new EntidadPais(bandera, txtNombre.Text, int .Parse(txtNoClubes.Text));
            mp.modificarPais(ep);
            txtNombre.Clear();
            txtNoClubes.Clear();
        }

        public void limpiarErrores()
        {
            errorProvider.SetError(txtNombre, "");
            errorProvider.SetError(txtNoClubes, "");
        }

        private void FrmPaisAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
