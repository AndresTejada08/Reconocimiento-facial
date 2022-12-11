using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ETipoUsuario
    {
        // ESTA CAPA HACE EL MAPEADO OBJETO - RELACIONAL
        // Atributos
        private int codTipoUsuario;
        private string tipoUsuario;

        // Propiedades
        public int CodTipoUsuario { get => codTipoUsuario; set => codTipoUsuario = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
    }
}
