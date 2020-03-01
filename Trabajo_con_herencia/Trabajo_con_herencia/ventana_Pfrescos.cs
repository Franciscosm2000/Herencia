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
    public partial class ventana_Pfrescos : Form
    {
        public ventana_Pfrescos()
        {
            InitializeComponent();
       
        }

        public static String[] datos = new String [100];
        public static int cont;
        private void Agregar_Click(object sender, EventArgs e)
        {
            Producto_Frescos pro = new Producto_Frescos();
            pro.Fecha_de_embazado = fecha_embazado.Value.ToLongDateString();
            pro.Fecha_de_caducidad = Fecha_caducidad.Value.ToLongDateString();
            pro.Pais_de_origen = Pais_origen.Text;
            pro.Numero_por_lote = Convert.ToInt32(numero_por_lote.Text);
            pro.Informacion_especifica = informacion_especifica.Text;

            lista.Items.Add("Fecha de Embazado: "+pro.Fecha_de_embazado);
            lista.Items.Add("Fecha de Caducidad: " + pro.Fecha_de_caducidad);
            lista.Items.Add("Pais de Origen : "+ pro.Pais_de_origen);
            lista.Items.Add("Numero por Lote : "+pro.Numero_por_lote);
            lista.Items.Add("Informacion Especifica : "+pro.Informacion_especifica);
            lista.Items.Add("");

            Pais_origen.Text = "";
            numero_por_lote.Text = "";
            informacion_especifica.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont = lista.Items.Count;

            for (int i=0; i<cont;i++)
            {
                datos[i] = lista.Items[i].ToString();
            }
            MessageBox.Show("Guardado Exitosamente");
        }

        private void informacion_especifica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
