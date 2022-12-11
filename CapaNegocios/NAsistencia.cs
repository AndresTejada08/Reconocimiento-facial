using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class NAsistencia : Interfaces.IAsistencia
    {
        // ESTA CAPA DEFINE LAS REGLAS DE NEGOCIO, ES DONDE ESTA LOS METODOS QUE HACE EL NEGOCIO

        // Un objeto para acceder a la capa de datos
        Datos datos = new DatosSQL();

        public DataSet Listar()
        {
            return datos.TraerDataSet("PA_ListarAsistencia");
        }

        public string[] Agregar(EAsistencia Asistencia)
        {
            DataRow row = datos.TraerDataRow("PA_AgregarAsistencia", Asistencia.Fecha, Asistencia.Hora, Asistencia.CodPersona);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public DataSet Buscar(string fecha1, string fecha2)
        {
            return datos.TraerDataSet("PA_BuscarAsistencia", fecha1, fecha2);
        }

        public DataSet BuscarCoencidencia(string buscar)
        {
            // Busca coencidencia entre la asistencia del módulo y la base datos
            return datos.TraerDataSet("PA_BuscarCoencidenciaPersona", buscar);
        }
    }
}
