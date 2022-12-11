using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface ITipoUsuario
    {
        // Declaración de los métodos de la clase ECliente
        DataSet Listar();
        string[] Agregar(ETipoUsuario TipoUsuario);
        string[] Actualizar(ETipoUsuario TipoUsuario);
        string[] Eliminar(int codTipoUsuario);
        DataSet Buscar(string texto, string criterio);
    }
}
