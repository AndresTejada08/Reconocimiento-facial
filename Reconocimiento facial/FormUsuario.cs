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
    public partial class FormUsuario : Form
    {
        // Llamar al servicio
        private static ServiceReference1.wsColegioSoapClient servicio;

        public FormUsuario()
        {
            InitializeComponent();
            ListarUsuarios();
        }

        private void Limpiar()
        {
            txtCodUsuario.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        public void ListarUsuarios()
        {
            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvUsuario.DataSource = servicio.ListarUsuario().Tables[0];
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            int tipo = Convert.ToInt32(cbTipo.Text);

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.AgregarUsuario(usuario, contrasena, tipo);

            ListarUsuarios();
            Limpiar();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            int codUsuario = Convert.ToInt32(txtCodUsuario.Text.Trim());

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.EliminarUsuario(codUsuario);

            ListarUsuarios();
            Limpiar();
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            int codUsuario = Convert.ToInt32(txtCodUsuario.Text.Trim());
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            int tipo = Convert.ToInt32(cbTipo.Text);

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            servicio.ActualizarUsuario(codUsuario, usuario, contrasena, tipo);

            ListarUsuarios();
            Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            string texto = txtBuscar.Text.Trim();
            string criterio = cbBuscar.Text;

            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvUsuario.DataSource = servicio.BuscarUsuario(texto, criterio).Tables[0];
        }

        private void dgvUsuario_DoubleClick(object sender, EventArgs e)
        {
            txtCodUsuario.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[0].Value);
            txtUsuario.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[1].Value);
            txtContrasena.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[2].Value);
            cbTipo.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[3].Value);
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
