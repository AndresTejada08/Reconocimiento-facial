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
    public partial class FormLogin : Form
    {
        // Llamar al servicio (Aun no hice la referencia del servicio)
        private static ServiceReference1.wsColegioSoapClient servicio;

        public FormLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void bttnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            string[] valores = servicio.Login(usuario, contrasena).ToArray();
            if (valores[0] == "0" && valores[1] == "ADMINISTRADOR")
            {
                FormPrincipal form = new FormPrincipal();
                form.Show();
                this.Hide();
            }
            else if (valores[0] == "0" && valores[1] == "DOCENTE")
            {
                MessageBox.Show("UD. ES DOCENTE, NO TIENE ACCESO AL SISTEMA", "Sistema de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(valores[1], "Sistema de Ventas");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.DarkGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
