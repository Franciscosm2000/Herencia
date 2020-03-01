using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_herencia
{
    class Productos_Congelados: Productos
    {
       private String fecha_de_embazado;
       private String pais_origen;
       private String t_de_enfri_recomendada;

        public string Fecha_de_embazado { get => fecha_de_embazado; set => fecha_de_embazado = value; }
        public string Pais_origen { get => pais_origen; set => pais_origen = value; }
        public string T_de_enfri_recomendada { get => t_de_enfri_recomendada; set => t_de_enfri_recomendada = value; }
    }
}
