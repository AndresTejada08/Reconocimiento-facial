using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EAsistencia
    {
        // ESTA CAPA HACE EL MAPEADO OBJETO - RELACIONAL
        // Atributos
        private int codAsistencia;
        private string fecha;
        private string hora;
        private int codPersona;
        private string buscar;

        //Propiedades
        public int CodAsistencia { get => codAsistencia; set => codAsistencia = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public int CodPersona { get => codPersona; set => codPersona = value; }
        public string Buscar { get => buscar; set => buscar = value; }
    }
}
