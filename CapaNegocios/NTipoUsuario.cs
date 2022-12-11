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
    public class NTipoUsuario : Interfaces.ITipoUsuario
    {
        // ESTA CAPA DEFINE LAS REGLAS DE NEGOCIO, ES DONDE ESTA LOS METODOS QUE HACE EL NEGOCIO

        // Un objeto para acceder a la capa de datos
        Datos datos = new DatosSQL();

        public DataSet Listar()
        {
            return datos.TraerDataSet("PA_ListarTipoUsuario");
        }

        public string[] Agregar(ETipoUsuario TipoUsuario)
        {
            DataRow row = datos.TraerDataRow("PA_AgregarTipoUsuario", TipoUsuario.TipoUsuario.Trim().ToUpper());

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Actualizar(ETipoUsuario TipoUsuario)
        {
            DataRow row = datos.TraerDataRow("PA_ActualizarTipoUsuario", TipoUsuario.CodTipoUsuario, TipoUsuario.TipoUsuario.Trim().ToUpper());

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Eliminar(int codTipoUsuario)
        {
            DataRow row = datos.TraerDataRow("PA_EliminarTipoUsuario", codTipoUsuario);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("PA_BuscarTipoUsuario", texto, criterio);
        }
    }
}
