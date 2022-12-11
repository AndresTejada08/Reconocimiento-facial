using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface IAsistencia
    {
        // Declaración de los métodos de la clase ECliente
        DataSet Listar();
        string[] Agregar(EAsistencia Asistencia);
        DataSet Buscar(string fecha1, string fecha2);
        DataSet BuscarCoencidencia(string buscar);
    }
}
