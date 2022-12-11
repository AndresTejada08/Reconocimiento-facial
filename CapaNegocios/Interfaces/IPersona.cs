using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaNegocios.Interfaces
{
    interface IPersona
    {
        // Declaración de los métodos de la clase ECliente
        DataSet Listar();
        string[] Agregar(EPersona Persona);
        string[] Actualizar(EPersona Persona);
        string[] Eliminar(int codPersona);
        DataSet Buscar(string texto, string criterio);
    }
}
