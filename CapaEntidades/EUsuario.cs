using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EUsuario
    {
        // ESTA CAPA HACE EL MAPEADO OBJETO - RELACIONAL
        // Atributos
        private int codUsuario;
        private string usuario;
        private string contrasena;
        private int tipo;

        //Propiedades
        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
