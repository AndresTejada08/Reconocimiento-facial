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
    public class NPersona : Interfaces.IPersona
    {
        // ESTA CAPA DEFINE LAS REGLAS DE NEGOCIO, ES DONDE ESTA LOS METODOS QUE HACE EL NEGOCIO

        // Un objeto para acceder a la capa de datos
        Datos datos = new DatosSQL();

        public DataSet Listar()
        {
            return datos.TraerDataSet("PA_ListarPersona");
        }

        public string[] Agregar(EPersona Persona)
        {
            DataRow row = datos.TraerDataRow("PA_AgregarPersona", Persona.Nombres.Trim().ToUpper(), Persona.Apellidos.Trim().ToUpper(),
                Persona.Tipo.Trim().ToUpper(), Persona.Telefono, Persona.Direccion.Trim().ToUpper());

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Actualizar(EPersona Persona)
        {
            DataRow row = datos.TraerDataRow("PA_ActualizarPersona", Persona.CodPersona, Persona.Nombres.Trim().ToUpper(), 
                Persona.Apellidos.Trim().ToUpper(), Persona.Tipo.Trim().ToUpper(), Persona.Telefono, Persona.Direccion.Trim().ToUpper());

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public string[] Eliminar(int codPersona)
        {
            DataRow row = datos.TraerDataRow("PA_EliminarPersona", codPersona);

            string[] msj = new string[2];
            msj[0] = row["CodError"].ToString();
            msj[1] = row["Mensaje"].ToString();

            return msj;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("PA_BuscarPersona", texto, criterio);
        }
    }
}
