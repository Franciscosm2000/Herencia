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
    public partial class Ventana_Prefrigerados : Form
    {
        
        Productos_Refrigerados pro = new Productos_Refrigerados();
        public Ventana_Prefrigerados()
        {
            InitializeComponent();
        }
        public static String [] Datos = new String [100] ;
        public static int cont = 0;
        private void Agregar_Click(object sender, EventArgs e)
        {
            pro.Fecha_de_embazado = fecha_embazado.Value.ToLongDateString();
            pro.Fecha_de_caducidad= fecha_vencimiento.Value.ToLongDateString(); 
            pro.Cod_de_super_alimenticia = CODSA.Text; 
            pro.T_de_man_recomendada = temperatura.Text;
            pro.Pais_origen = pais_origen.Text; 
            pro.Numero_por_lote = Convert.ToInt32(numero_por_lotes.Text);
            pro.Informacion_especifica = informacion_especi.Text;
            //Imprimiendo
            lista.Items.Add("Fecha de Embazado : "+ pro.Fecha_de_embazado);
            lista.Items.Add("Fecha de Caducidad : "+ pro.Fecha_de_caducidad);
            lista.Items.Add("Codigo de supervicion alimentaria :" + pro.Cod_de_super_alimenticia);
            lista.Items.Add("Temperatura Recomendada de Mantenimiento :"+ pro.T_de_man_recomendada);
            lista.Items.Add("Pais de Origen :"+ pro.Pais_origen);
            lista.Items.Add("Numero por Lote :"+ pro.Numero_por_lote);
            lista.Items.Add("Informacion Especifica : "+ pro.Informacion_especifica);
            lista.Items.Add("");

            

        }

        private void Agregar_MouseClick(object sender, MouseEventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agregando al array
            cont = lista.Items.Count;

            for (int i = 0; i < cont; i++)
            {
                Datos[i] = lista.Items[i].ToString();
            }

            CODSA.Text = "";
            temperatura.Text = "";
            pais_origen.Text = "";
            numero_por_lotes.Text = "";
            informacion_especi.Text = "";
            MessageBox.Show("Guardado Exitosamente");
        }
    }
}
