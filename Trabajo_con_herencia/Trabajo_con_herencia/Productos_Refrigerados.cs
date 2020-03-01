using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_con_herencia
{
    class Productos_Refrigerados : Productos
    {
        private String cod_de_super_alimenticia;
        private String fecha_de_embazado;
        private String t_de_man_recomendada;
        private String pais_origen;

        public string Cod_de_super_alimenticia { get { return cod_de_super_alimenticia; } set { cod_de_super_alimenticia = value; } }
        public string Fecha_de_embazado { get => fecha_de_embazado; set => fecha_de_embazado = value; }
        public string T_de_man_recomendada { get => t_de_man_recomendada; set => t_de_man_recomendada = value; }
        public string Pais_origen { get => pais_origen; set => pais_origen = value; }

        

      
    }
}
