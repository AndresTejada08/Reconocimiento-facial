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
    public partial class FormPrincipal : Form
    {
        private Form formActivado = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void bttnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bttnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            bttnMaximizar.Visible = true;
            bttnRestaurar.Visible = false;
        }

        private void bttnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            bttnMaximizar.Visible = false;
            bttnRestaurar.Visible = true;
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿SEGURO DESEA SALIR DEL SISTEMA?", "Grupo Wirakochas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
                Application.Exit();
        }

        private void AbrirFormularios(Form formHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = formHijo;
            formHijo.TopLevel = false;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void bttnMenú_Click(object sender, EventArgs e)
        {
            if (panelLateral.Width == 270)
            {
                panelLateral.Visible = false;
                panelLateral.Width = 68;
            }
            else
            {
                panelLateral.Visible = false;
                panelLateral.Width = 270;
            }
        }

        private void bttnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormDashboard());
        }

        private void bttnPersona_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormPersona());
        }

        private void bttnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormUsuario());
        }

        private void bttnReconocimientoFacial_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormReconocimiento());
        }

        private void bttnAsistencia_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormAsistencia());
        }
    }
}
