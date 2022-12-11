using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CapaNegocios;
using CapaEntidades;

namespace CapaServicios
{
    /// <summary>
    /// Descripción breve de wsColegio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsColegio : System.Web.Services.WebService
    {
        // ====================================== USUARIO ======================================

        [WebMethod(Description = "Login de Usuario")]
        public String[] Login(String usuario, string contrasena)
        {
            EUsuario eUsuario = new EUsuario();
            NUsuario nUsuario = new NUsuario();

            eUsuario.Usuario = usuario;
            eUsuario.Contrasena = contrasena;

            bool CodError = nUsuario.Login(eUsuario);
            string[] valores = new string[2];
            if (CodError == true)
                valores[0] = "0"; // Correcto
            else
                valores[0] = "1"; // Error
            valores[1] = nUsuario.Mensaje;

            return valores;
        }

        [WebMethod(Description = "Muestra los datos de la tabla usuario")]
        public DataSet ListarUsuario()
        {

            NUsuario nUsuario = new NUsuario();
            return nUsuario.Listar();
        }

        [WebMethod(Description = "Agrega un nuevo usuario")]
        public string[] AgregarUsuario(string usuario, string contrasena, int tipo)
        {
            NUsuario nUsuario = new NUsuario();
            EUsuario eUsuario = new EUsuario();
            eUsuario.Usuario = usuario;
            eUsuario.Contrasena = contrasena;
            eUsuario.Tipo = tipo;
            return nUsuario.Agregar(eUsuario);

        }

        [WebMethod(Description = "Actualiza a un usuario")]
        public string[] ActualizarUsuario(int codUsuario, string usuario, string contrasena, int tipo)
        {
            NUsuario nUsuario = new NUsuario();
            EUsuario eUsuario = new EUsuario();
            eUsuario.CodUsuario = codUsuario;
            eUsuario.Usuario = usuario;
            eUsuario.Contrasena = contrasena;
            eUsuario.Tipo = tipo;
            return nUsuario.Actualizar(eUsuario);
        }

        [WebMethod(Description = "Eliminar a un usuario")]
        public string[] EliminarUsuario(int codUsuario)
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.Eliminar(codUsuario);
        }

        [WebMethod(Description = "Busca a un usuario")]
        public DataSet BuscarUsuario(string texto, string criterio)
        {
            NUsuario nUsuario = new NUsuario();
            return nUsuario.Buscar(texto, criterio);
        }

        // ====================================== TIPO USUARIO ======================================

        [WebMethod(Description = "Muestra los datos de la tabla persona")]
        public DataSet ListarTipoUsuario()
        {

            NTipoUsuario nTipoUsuario = new NTipoUsuario();
            return nTipoUsuario.Listar();
        }

        [WebMethod(Description = "Agrega un nuevo tipo de usuario")]
        public string[] AgregarTipoUsuario(string tipoUsuario)
        {
            NTipoUsuario nTipoUsuario = new NTipoUsuario();
            ETipoUsuario eTipoUsuario = new ETipoUsuario();
            eTipoUsuario.TipoUsuario = tipoUsuario;
            return nTipoUsuario.Agregar(eTipoUsuario);

        }

        [WebMethod(Description = "Elimina a un tipo de usuario")]
        public string[] EliminarTipoUsuario(int codTipoUsuario)
        {
            NTipoUsuario nTipoUsuario = new NTipoUsuario();
            return nTipoUsuario.Eliminar(codTipoUsuario);
        }

        [WebMethod(Description = "Actualiza a un tipo de usuario")]
        public string[] ActualizarTipoUsuario(int codTipoUsuario, string tipoUsuario)
        {
            NTipoUsuario nTipoUsuario = new NTipoUsuario();
            ETipoUsuario eTipoUsuario = new ETipoUsuario();
            eTipoUsuario.CodTipoUsuario = codTipoUsuario;
            eTipoUsuario.TipoUsuario = tipoUsuario;
            return nTipoUsuario.Actualizar(eTipoUsuario);
        }

        [WebMethod(Description = "Busca un tipo de usuario")]
        public DataSet BuscarTipoUsuario(string texto, string criterio)
        {
            NTipoUsuario nTipoUsuario = new NTipoUsuario();
            return nTipoUsuario.Buscar(texto, criterio);
        }

        // ====================================== PERSONA ======================================

        [WebMethod(Description = "Muestra los datos de la tabla persona")]
        public DataSet ListarPersona()
        {

            NPersona nPersona = new NPersona();
            return nPersona.Listar();
        }

        [WebMethod(Description = "Agrega una nueva persona")]
        public string[] AgregarPersona(string nombres, string apellidos, string tipo, int telefono, string direccion)
        {
            NPersona nPersona = new NPersona();
            EPersona ePersona = new EPersona();
            ePersona.Nombres = nombres;
            ePersona.Apellidos = apellidos;
            ePersona.Tipo = tipo;
            ePersona.Telefono = telefono;
            ePersona.Direccion = direccion;
            return nPersona.Agregar(ePersona);

        }

        [WebMethod(Description = "Elimina a una persona")]
        public string[] EliminarPersona(int codPersona)
        {
            NPersona nPersona = new NPersona();
            return nPersona.Eliminar(codPersona);
        }

        [WebMethod(Description = "Actualiza a una persona")]
        public string[] ActualizarPersona(int codPersona, string nombres, string apellidos, string tipo, int telefono, string direccion)
        {
            NPersona nPersona = new NPersona();
            EPersona ePersona = new EPersona();
            ePersona.CodPersona = codPersona;
            ePersona.Nombres = nombres;
            ePersona.Apellidos = apellidos;
            ePersona.Tipo = tipo;
            ePersona.Telefono = telefono;
            ePersona.Direccion = direccion;
            return nPersona.Actualizar(ePersona);
        }

        [WebMethod(Description = "Busca a una persona")]
        public DataSet BuscarPersona(string texto, string criterio)
        {
            NPersona nPersona = new NPersona();
            return nPersona.Buscar(texto, criterio);
        }

        // ====================================== ASISTENCIA ======================================

        [WebMethod(Description = "Muestra los datos de la tabla asistencia")]
        public DataSet ListarAsistencia()
        {

            NAsistencia nAsistencia = new NAsistencia();
            return nAsistencia.Listar();
        }

        [WebMethod(Description = "Agrega una nueva asistencia")]
        public string[] AgregarAsistencia(string fecha, string hora, int codPersona)
        {
            NAsistencia nAsistencia = new NAsistencia();
            EAsistencia eAsistencia = new EAsistencia();
            eAsistencia.Fecha = fecha;
            eAsistencia.Hora = hora;
            eAsistencia.CodPersona = codPersona;
            return nAsistencia.Agregar(eAsistencia);

        }

        [WebMethod(Description = "Busca una asistencia")]
        public DataSet BuscarAsistencia(string fecha1, string fecha2)
        {
            NAsistencia nAsistencia = new NAsistencia();
            return nAsistencia.Buscar(fecha1, fecha2);
        }

        [WebMethod(Description = "Busca si hay coencidencia entre la persona escanead y los registros de la base de datos")]
        public DataSet BuscarCoencidencia(string texto)
        {
            NAsistencia nAsistencia = new NAsistencia();
            return nAsistencia.BuscarCoencidencia(texto);
        }
    }
}
