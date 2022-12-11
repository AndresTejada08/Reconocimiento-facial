using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    public partial class FormPersona : Form
    {
        // Llamar al servicio
        private static ServiceReference1.wsColegioSoapClient servicio;

        public FormPersona()
        {
            InitializeComponent();
            ListarPersonas();
        }

        private void Limpiar()
        {
            txtCodPersona.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cbTipo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
        }

        public void ListarPersonas()
        {
            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvUsuario.DataSource = servicio.ListarPersona().Tables[0];
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string tipo = cbTipo.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);
            string direccion = txtDireccion.Text;

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.AgregarPersona(nombres, apellidos, tipo, telefono, direccion);

            ListarPersonas();
            Limpiar();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            int codPersona = Convert.ToInt32(txtCodPersona.Text.Trim());

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.EliminarPersona(codPersona);

            ListarPersonas();
            Limpiar();
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            int codPersona = Convert.ToInt32(txtCodPersona.Text.Trim());
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string tipo = cbTipo.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);
            string direccion = txtDireccion.Text;

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.ActualizarPersona(codPersona, nombres, apellidos, tipo, telefono, direccion);

            ListarPersonas();
            Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            string texto = txtBuscar.Text.Trim();
            string criterio = cbBuscar.Text;

            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvUsuario.DataSource = servicio.BuscarPersona(texto, criterio).Tables[0];
        }

        private void dgvUsuario_DoubleClick(object sender, EventArgs e)
        {
            txtCodPersona.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[0].Value);
            txtNombres.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[1].Value);
            txtApellidos.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[2].Value);
            cbTipo.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[3].Value);
            txtTelefono.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[4].Value);
            txtDireccion.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[5].Value);
        }
    }
}
