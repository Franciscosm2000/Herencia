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
    public partial class testHerencia3 : Form
    {
        public testHerencia3()
        {
            InitializeComponent();
        }

        private void frescosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventana_Pfrescos ven = new ventana_Pfrescos();
            ven.Visible = true;
        }

        private void refrigeradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Prefrigerados ven = new Ventana_Prefrigerados();
            ven.Visible = true;
        }

        private void productosCongeladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrando mos = new Mostrando("Refrigerados");
            mos.Visible = true;
        }

        private void productosFrescosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrando mos = new Mostrando("Fresco");
            mos.Visible = true;
        }

        private void congeladosPorAireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vcongelado_Acs v = new Vcongelado_Acs();
            v.Visible = true;
        }

        private void congeladosPorAguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vcongelado_agua con = new Vcongelado_agua();
            con.Show();
        }

        private void productosCongeladosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mostrando mos = new Mostrando("Congelados");
            mos.Visible = true;
        }

        private void testHerencia3_Load(object sender, EventArgs e)
        {
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrando mos = new Mostrando("Todo");
            mos.Show();
        }

        private void congeladosPorNitrogenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vcongelado_nitro con = new Vcongelado_nitro();
            con.Show();
        }

        private void mostrarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ECHO POR FRANCISCO JAVIER SANDOVAL MALDONADO");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
