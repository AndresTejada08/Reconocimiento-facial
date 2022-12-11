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
    public partial class FormAsistencia : Form
    {
        // Llamar al servicio
        private static ServiceReference1.wsColegioSoapClient servicio;

        public FormAsistencia()
        {
            InitializeComponent();
            ListarAsistencia();
        }

        public void ListarAsistencia()
        {
            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvUsuario.DataSource = servicio.ListarAsistencia().Tables[0];
        }

        private void bttnBuscarFecha_Click(object sender, EventArgs e)
        {
            // Variables
            string fecha1 = dtpFecha1.Value.ToString("dd/MM/yyyy");
            string fecha2 = dtpFecha1.Value.ToString("dd/MM/yyyy");

            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvUsuario.DataSource = servicio.BuscarAsistencia(fecha1, fecha2).Tables[0];
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
