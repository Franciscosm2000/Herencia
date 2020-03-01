using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_herencia
{
    class Producto_Frescos : Productos
    {
        private String fecha_de_embazado;
        private String pais_de_origen;

        public Producto_Frescos(String fecha, String fecha1,int N, String inf, String p)
        {
            this.fecha_de_embazado = fecha;
            this.Fecha_de_caducidad = fecha1;
            this.Numero_por_lote = N;
            this.Informacion_especifica = inf;
            this.Pais_de_origen = pais_de_origen;
        }
        public Producto_Frescos()
        { }
        public string Fecha_de_embazado { get => fecha_de_embazado; set => fecha_de_embazado = value; }
        public string Pais_de_origen { get => pais_de_origen; set => pais_de_origen = value; }
    }
}
