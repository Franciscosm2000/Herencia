using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_herencia
{
    class Congelado_por_nitrogeno : Productos_Congelados
    {
        private String inf_del_metodo;
        private String tiempo_de_exposicion_enS;

        public string Inf_del_metodo { get => inf_del_metodo; set => inf_del_metodo = value; }
        public string Tiempo_de_exposicion_enS { get => tiempo_de_exposicion_enS; set => tiempo_de_exposicion_enS = value; }
    }
}
