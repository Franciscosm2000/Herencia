using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_herencia
{
    class Productos
    {
        private String fecha_de_caducidad;
        private int numero_por_lote;
        private String informacion_especifica;

        public string Fecha_de_caducidad { get => fecha_de_caducidad; set => fecha_de_caducidad = value; }
        public int Numero_por_lote { get => numero_por_lote; set => numero_por_lote = value; }
        public string Informacion_especifica { get => informacion_especifica; set => informacion_especifica = value; }
    }
}
