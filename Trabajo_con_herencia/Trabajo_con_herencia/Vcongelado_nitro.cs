using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_con_herencia
{
    public partial class Vcongelado_nitro : Form
    {
        public Vcongelado_nitro()
        {
            InitializeComponent();
        }

        public static String[] datos = new String[100];
        public static int cont;
        private void Agregar_Click(object sender, EventArgs e)
        {
            Congelado_por_nitrogeno con = new Congelado_por_nitrogeno();
            con.Fecha_de_embazado = fecha.Value.ToLongDateString();
            con.Fecha_de_caducidad = Fecha2.Value.ToLongDateString();
            con.Pais_origen = pais.Text;
            con.Numero_por_lote = Convert.ToInt32(numero.Text);
            con.Informacion_especifica = inf.Text;
            con.Tiempo_de_exposicion_enS = tiempo.Text;
            con.Inf_del_metodo = inf_compo.Text;

            listBox1.Items.Add("Fecha de Embazado : "+con.Fecha_de_embazado);
            listBox1.Items.Add("Fecha de Caducidad : " +con.Fecha_de_caducidad);
            listBox1.Items.Add("Pais de Origen : " +con.Pais_origen);
            listBox1.Items.Add("Numero por Lote : " +con.Numero_por_lote);
            listBox1.Items.Add("Informacion DEl Metodo : " +con.Inf_del_metodo);
            listBox1.Items.Add("Tiempo De Exposicion : " +con.Tiempo_de_exposicion_enS);
            listBox1.Items.Add("Informacion Especifica : " +con.Informacion_especifica );
            listBox1.Items.Add("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont = listBox1.Items.Count;
            for (int i=0; i<cont; i++)
            {
                datos[i] = listBox1.Items[i].ToString();
            }
            pais.Text = "";
            numero.Text = "";
            inf_compo.Text = "";
            inf.Text = "";
            tiempo.Text = "";
        }
    }
}
