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
    public partial class Vcongelado_Acs : Form
    {
        public Vcongelado_Acs()
        {
            InitializeComponent();
        }
        public static String [] datos= new String [100];
        public static int cont;
        private void button1_Click(object sender, EventArgs e)
        {
            Congelados_por_aire con = new Congelados_por_aire();
            con.Fecha_de_embazado = fecha.Text;
            con.Fecha_de_caducidad = Fecha2.Text;
            con.Pais_origen = pais.Text;
            con.Numero_por_lote = Convert.ToInt32(numero.Text);
            con.Informacion_especifica = inf.Text;
            con.T_de_enfri_recomendada = Temperatura.Text;

            con.Porcentaje_de_nitrogeno = nitrogeno.Text;
            con.Porcentaje_de_dioxidoC = dioxido.Text;
            con.Porcentaje_de_oxigeno = oxigeno.Text;
            con.Porcentaje_de_vaporA = vapor.Text;

            listBox1.Items.Add("Fecha de Embazado : " + con.Fecha_de_embazado);
            listBox1.Items.Add("Fecha de Caducidad : "+ con.Fecha_de_caducidad);
            listBox1.Items.Add("Pais de Origen : "+ con.Pais_origen);
            listBox1.Items.Add("Numero Por Lote : "+ con.Numero_por_lote);
            listBox1.Items.Add("Pocentaje de Nitrogeno :"+ con.Porcentaje_de_nitrogeno);
            listBox1.Items.Add("Pocentaje de Dioxido De Carbono :" + con.Porcentaje_de_dioxidoC);
            listBox1.Items.Add("Pocentaje de Oxigeno :" + con.Porcentaje_de_oxigeno);
            listBox1.Items.Add("Pocentaje de Vapor de Agua :" + con.Porcentaje_de_vaporA);
            listBox1.Items.Add("Informacion Especifica : "+ con.Informacion_especifica);
            listBox1.Items.Add("");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont = listBox1.Items.Count;
            for (int i=0; i<cont;i++)
            {
                datos[i] = listBox1.Items[i].ToString();
            }
            pais.Text = "";
            numero.Text = "";
            inf.Text = "";
            Temperatura.Text = "";
            nitrogeno.Text = "";
            oxigeno.Text = "";
            dioxido.Text = "";
            vapor.Text = "";
            MessageBox.Show("Guardado Exitosamente");
        }
    }
}
