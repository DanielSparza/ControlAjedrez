using System;
using System.Windows.Forms;
using EntidadesAjedrez;
using ManejadorAjedrez;

namespace PresentacionAjedrez
{
    public partial class FrmCampeonatosAdd : Form
    {
        ManejadorCampeonato mc;
        EntidadCampeonato ec = new EntidadCampeonato("", 0, "", "");
        int bandera, fila;

        public FrmCampeonatosAdd()
        {
            InitializeComponent();
            mc = new ManejadorCampeonato();
        }

        public FrmCampeonatosAdd(EntidadCampeonato campeonato)
        {
            InitializeComponent();
            mc = new ManejadorCampeonato();

            txtIdCampeonato.Text = campeonato.IdCampeonato.ToString();
            txtParticipante.Text = campeonato.FkPersona;
            txtNomCampeonato.Text = campeonato.NombreCampeonato;
            bandera = campeonato.IdCampeonato;
            txtIdCampeonato.Enabled = false;
        }

        private void FrmCampeonatosAdd_Load(object sender, EventArgs e)
        {
            cargarDatos("");
        }

        public void cargarDatos(string busqueda)
        {
            dtgPersonas.DataSource = mc.mostrarPerona(busqueda).Tables[0];
        }

        public void limpiarCuadros()
        {
            txtIdCampeonato.Clear();
            txtNomCampeonato.Clear();
            txtParticipante.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mc.validarVacio(txtIdCampeonato) && mc.validarVacio(txtNomCampeonato) && mc.validarVacio(txtParticipante) && mc.validarNumeros(txtIdCampeonato) && cmbTipo.Text.Length > 0 && cmbTipo.Text != null)
            {
                if (bandera > 0)
                {
                    modificarCampeonato();
                    MessageBox.Show("El registro se modificó correctamente");
                    limpiarCuadros();
                    limpiarErrores();
                    Close();
                }
                else
                {
                    guardarCampeonato();
                    MessageBox.Show("Registro añadido correctamente");
                    limpiarCuadros();
                    limpiarErrores();
                }
            }
            else if (!mc.validarVacio(txtIdCampeonato))
            {
                errorProvider.SetError(txtIdCampeonato, "No se puede dejar el campo Id Campeonato vacío");
            }
            else if (!mc.validarVacio(txtParticipante))
            {
                errorProvider.SetError(txtParticipante, "No seleccionó ningún participante");
            }
            else if (!mc.validarVacio(txtNomCampeonato))
            {
                errorProvider.SetError(txtNomCampeonato, "No se puede dejer el campo Nombre campeonato vacío");
            }
            else if (!mc.validarNumeros(txtIdCampeonato))
            {
                errorProvider.SetError(txtIdCampeonato, "Solo se permiten caracteres Numéricos");
            }
            else if (cmbTipo.Text.Length == 0 || cmbTipo.Text == null)
            {
                errorProvider.SetError(cmbTipo, "No seleccionó ningún tipo");
            }
        }

        public void limpiarErrores()
        {
            errorProvider.SetError(txtIdCampeonato, "");
            errorProvider.SetError(txtNomCampeonato, "");
            errorProvider.SetError(txtParticipante, "");
            errorProvider.SetError(cmbTipo, "");
        }

        public void guardarCampeonato()
        {
            ec = new EntidadCampeonato(txtParticipante.Text, int.Parse(txtIdCampeonato.Text), txtNomCampeonato.Text, cmbTipo.Text);
            mc.guardarCampeonato(ec);
        }

        public void modificarCampeonato()
        {
            ec = new EntidadCampeonato(txtParticipante.Text, bandera, txtNomCampeonato.Text, cmbTipo.Text);
            mc.modificarCampeonato(ec);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatos(txtBuscar.Text);
        }

        private void dtgPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;

                txtParticipante.Text = dtgPersonas.Rows[fila].Cells[0].Value.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("La fila seleccionada está vacía.");
            }
            catch (Exception)
            {

            }
        }
    }
}
