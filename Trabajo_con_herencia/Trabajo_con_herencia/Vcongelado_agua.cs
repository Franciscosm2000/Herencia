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
    public partial class Vcongelado_agua : Form
    {
        public Vcongelado_agua()
        {
            InitializeComponent();
        }

        public static String[] datos = new String[100];
        public static int cont;
        private void button1_Click(object sender, EventArgs e)
        {
            Congelado_por_agua con = new Congelado_por_agua();
            con.Fecha_de_embazado = fecha.Value.ToLongDateString();
            con.Fecha_de_caducidad = Fecha2.Value.ToLongDateString();
            con.Pais_origen = pais.Text;
            con.Numero_por_lote = Convert.ToInt32(numero.Text);
            con.Salinidad_agua = inf_sali.Text;
            con.Informacion_especifica = inf.Text;

            listBox1.Items.Add("Fecha de Embazado : "+con.Fecha_de_embazado);
            listBox1.Items.Add("Fecha de Caducidad : " +con.Fecha_de_caducidad);
            listBox1.Items.Add("Pais de Origen : " +con.Pais_origen);
            listBox1.Items.Add("Numero Por Lote : "  +con.Numero_por_lote);
            listBox1.Items.Add("Salinidad del Agua : " +con.Salinidad_agua);
            listBox1.Items.Add("Informacion Especifica" +con.Informacion_especifica);
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
            inf_sali.Text = "";
            inf.Text="";
            MessageBox.Show("Guardado Correctamente");
        }
    }
}
