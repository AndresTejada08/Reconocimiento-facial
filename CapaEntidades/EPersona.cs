using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EPersona
    {
        // ESTA CAPA HACE EL MAPEADO OBJETO - RELACIONAL
        // Atributos
        private int codPersona;
        private string nombres;
        private string apellidos;
        private string tipo;
        private int telefono;
        private string direccion;

        //Propiedades
        public int CodPersona { get => codPersona; set => codPersona = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
