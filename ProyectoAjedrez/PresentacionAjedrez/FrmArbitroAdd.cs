using System;
using System.Windows.Forms;
using ManejadorAjedrez;
using EntidadesAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmArbitroAdd : Form
    {
        ManejadorArbitro ma;
        EntidadArbitro ea = new EntidadArbitro("", "", "", "", "", "", 0);
        string bandera;

        public FrmArbitroAdd()
        {
            InitializeComponent();
            ma = new ManejadorArbitro();
        }

        public FrmArbitroAdd(EntidadArbitro arbitro)
        {
            InitializeComponent();
            ma = new ManejadorArbitro();

            txtCodigo.Text = arbitro.IdArbitro;
            txtNombre.Text = arbitro.Nombre;
            txtApPaterno.Text = arbitro.ApPaterno;
            txtApMaterno.Text = arbitro.ApMaterno;
            txtDireccion.Text = arbitro.Direccion;
            txtTelefono.Text = arbitro.Telefono;
            bandera = arbitro.IdArbitro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int fkid = ma.obtenerId(cmbPais.Text);

            if (validarVacios() && ma.validarNumeros(txtTelefono) && fkid > 0)
            {
                if (bandera != null)
                {
                    modificarArbitro(fkid);
                    MessageBox.Show("El registro se modificó correctamente");
                    limpiarCuadros();
                    limpiarErrores();
                    Close();
                }
                else
                {
                    guardarArbitro(fkid);
                    MessageBox.Show("Registro añadido correctamente");
                    limpiarCuadros();
                    limpiarErrores();
                }
            }
            else if (!validarVacios())
            {
                MessageBox.Show("No se puede dejar ningún campo vacío");
            }
            else if (!ma.validarNumeros(txtTelefono))
            {
                errorProvider.SetError(txtTelefono,"Solo se permiten caracteres numéricos");
            }
            else if (fkid <= 0)
            {
                errorProvider.SetError(cmbPais, "No seleccionó ningún país");
            }
        }

        public void limpiarCuadros()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        public bool validarVacios()
        {
            bool r = false;

            if (ma.validarVacio(txtCodigo))
            {
                if (ma.validarVacio(txtNombre))
                {
                    if (ma.validarVacio(txtApPaterno))
                    {
                        if (ma.validarVacio(txtApMaterno))
                        {
                            if (ma.validarVacio(txtDireccion))
                            {
                                if (ma.validarVacio(txtTelefono))
                                {
                                    r = true;
                                }
                            }
                        }
                    }
                }
            }  
            return r;
        }

        public void guardarArbitro( int fkid)
        {
            ea = new EntidadArbitro(txtCodigo.Text, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, txtDireccion.Text, txtTelefono.Text, fkid);
            ma.guardarPersona(ea);
            ma.guardarArbitro(ea);
        }

        public void modificarArbitro(int fkid)
        {
            ea = new EntidadArbitro(bandera, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, txtDireccion.Text, txtTelefono.Text, fkid);
            ma.modificarPersona(ea);
        }

        private void llenarComboPais()
        {
            ma.llenarCombobox(cmbPais);
        }

        private void FrmArbitroAdd_Load(object sender, EventArgs e)
        {
            llenarComboPais();
        }

        public void limpiarErrores()
        {
            errorProvider.SetError(txtTelefono, "");
            errorProvider.SetError(cmbPais, "");
        }
    }
}
