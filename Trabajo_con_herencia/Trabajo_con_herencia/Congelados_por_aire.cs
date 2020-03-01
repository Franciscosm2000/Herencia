using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_herencia
{
    class Congelados_por_aire : Productos_Congelados
    {
        private String porcentaje_de_nitrogeno;
        private String porcentaje_de_oxigeno;
        private String porcentaje_de_dioxidoC;
        private String porcentaje_de_vaporA;

        public string Porcentaje_de_nitrogeno { get => porcentaje_de_nitrogeno; set => porcentaje_de_nitrogeno = value; }
        public string Porcentaje_de_oxigeno { get => porcentaje_de_oxigeno; set => porcentaje_de_oxigeno = value; }
        public string Porcentaje_de_dioxidoC { get => porcentaje_de_dioxidoC; set => porcentaje_de_dioxidoC = value; }
        public string Porcentaje_de_vaporA { get => porcentaje_de_vaporA; set => porcentaje_de_vaporA = value; }
    }
}
