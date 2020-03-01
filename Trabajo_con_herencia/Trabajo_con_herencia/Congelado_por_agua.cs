using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_herencia
{
    class Congelado_por_agua:Productos_Congelados
    {
        private String salinidad_agua;

        public string Salinidad_agua { get => salinidad_agua; set => salinidad_agua = value; }
    }
}
