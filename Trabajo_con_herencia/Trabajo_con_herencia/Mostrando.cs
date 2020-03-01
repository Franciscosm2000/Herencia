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
    public partial class Mostrando : Form
    {

        private String ti;
        int x = 2;
        int s = 2;
        int z = 1;
        int u = 1;
        int w = 1;

        public Mostrando(String tipo)
        {
            InitializeComponent();
            this.ti = tipo;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mostrando_Load(object sender, EventArgs e)
        {
            

            switch (ti)
            {
                case "Fresco":
                    //frescos
                    listBox1.Items.Add("Numero 1");
                    listBox1.Items.Add("Fecha de Embazado: 13/05/2002");
                    listBox1.Items.Add("Fecha de Caducidad: 13/12/2002" );
                    listBox1.Items.Add("Pais de Origen : Nicaragua" );
                    listBox1.Items.Add("Numero por Lote : 5" );
                    listBox1.Items.Add("Informacion Especifica : Manzana");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Numero 2");
                    listBox1.Items.Add("Fecha de Embazado: 13/12/2005");
                    listBox1.Items.Add("Fecha de Caducidad: 13/04/2006");
                    listBox1.Items.Add("Pais de Origen : Mexico");
                    listBox1.Items.Add("Numero por Lote : 5");
                    listBox1.Items.Add("Informacion Especifica : Peras");
                    listBox1.Items.Add("");

                    for (int d = 0; d < ventana_Pfrescos.cont; d++)
                    {
                        if (d % 6 == 0)
                        {
                            s++;
                            listBox1.Items.Add("Numero :" + s);
                            listBox1.Items.Add(ventana_Pfrescos.datos[d].ToString());
                        }
                        else
                        {
                            listBox1.Items.Add(ventana_Pfrescos.datos[d].ToString());
                        }
                    }
                    break;
                case "Refrigerados":
                    listBox2.Items.Add("Numero 1");
                    listBox2.Items.Add("Fecha de Embazado : 12/12/2012");
                    listBox2.Items.Add("Fecha de Caducidad : 12/01/2014" );
                    listBox2.Items.Add("Codigo de supervicion alimentaria : 002-00s" );
                    listBox2.Items.Add("Temperatura Recomendada de Mantenimiento : 25g");
                    listBox2.Items.Add("Pais de Origen : Costa Rica" );
                    listBox2.Items.Add("Numero por Lote : 15" );
                    listBox2.Items.Add("Informacion Especifica : Huevos");
                    listBox2.Items.Add("");
                    listBox2.Items.Add("Numero 2");
                    listBox2.Items.Add("Fecha de Embazado : 12/12/2016");
                    listBox2.Items.Add("Fecha de Caducidad : 12/01/2017");
                    listBox2.Items.Add("Codigo de supervicion alimentaria : 002-01s");
                    listBox2.Items.Add("Temperatura Recomendada de Mantenimiento : 15g");
                    listBox2.Items.Add("Pais de Origen : Costa Marfil");
                    listBox2.Items.Add("Numero por Lote : 13");
                    listBox2.Items.Add("Informacion Especifica : Mantequilla");
                    listBox2.Items.Add("");
                    for (int i = 0; i < Ventana_Prefrigerados.cont; i++)
                    {
                        if (i % 8 == 0)
                        {
                            x++;
                            listBox2.Items.Add("Producto Numero: " + "<" + x + ">");
                            listBox2.Items.Add(Ventana_Prefrigerados.Datos[i].ToString());
                        }
                        else
                        {
                            listBox2.Items.Add(Ventana_Prefrigerados.Datos[i].ToString());
                        }

                    }
                    break;
                case "Congelados":
                    // congelados por aire
                    listBox3.Items.Add("Numero:  1");
                    listBox3.Items.Add("Fecha de Embazado : 11/11/2011");
                    listBox3.Items.Add("Fecha de Caducidad : 12/12/2012");
                    listBox3.Items.Add("Pais de Origen : Cuba" );
                    listBox3.Items.Add("Numero Por Lote : 156" );
                    listBox3.Items.Add("Pocentaje de Nitrogeno : 1%" );
                    listBox3.Items.Add("Pocentaje de Dioxido De Carbono : 2%");
                    listBox3.Items.Add("Pocentaje de Oxigeno : 3% " );
                    listBox3.Items.Add("Pocentaje de Vapor de Agua :5% " );
                    listBox3.Items.Add("Informacion Especifica : Nugets" );
                    listBox3.Items.Add("");
                    for (int q = 0; q < Vcongelado_Acs.cont; q++)
                    {
                        if (q % 11 == 0)
                        {
                            z++;
                            listBox3.Items.Add("Numero :" + z + "  << Congelado por Aire >>");
                            listBox3.Items.Add(Vcongelado_Acs.datos[q].ToString());
                        }
                        else
                        {
                            listBox3.Items.Add(Vcongelado_Acs.datos[q].ToString());
                        }
                    }
                    //Congelados por Agua
                    listBox4.Items.Add("Numero : 1");
                    listBox4.Items.Add("Fecha de Embazado : 5/05/2005" );
                    listBox4.Items.Add("Fecha de Caducidad : 6/06/2006" );
                    listBox4.Items.Add("Pais de Origen : Colombia" );
                    listBox4.Items.Add("Numero Por Lote : 12" );
                    listBox4.Items.Add("Salinidad del Agua : 2 gs/ltsA");
                    listBox4.Items.Add("Informacion Especifica: Tomate" );
                    listBox4.Items.Add("");
                    for (int it = 0; it < Vcongelado_agua.cont; it++)
                    {
                        if (it % 8 == 0)
                        {
                            u++;
                            listBox4.Items.Add("Numero :" + u + "  << Congelado por Agua >>");
                            listBox4.Items.Add(Vcongelado_agua.datos[it].ToString());
                        }
                        else
                        {
                            listBox4.Items.Add(Vcongelado_agua.datos[it].ToString());
                        }
                    }
                    //Congelado por nitrogeno
                    listBox5.Items.Add("Fecha de Embazado : 10/10/2010 " );
                    listBox5.Items.Add("Fecha de Caducidad : 15/12/2015");
                    listBox5.Items.Add("Pais de Origen : Venezuela " );
                    listBox5.Items.Add("Numero por Lote : 25" );
                    listBox5.Items.Add("Informacion DEl Metodo : Cogelado al 100 ");
                    listBox5.Items.Add("Tiempo De Exposicion : 1000S" );
                    listBox5.Items.Add("Informacion Especifica : nose" );
                    listBox5.Items.Add("");
                    for (int h = 0; h < Vcongelado_nitro.cont; h++)
                    {
                        if (h % 9 == 0)
                        {
                            w++;
                            listBox5.Items.Add("Numero :" + w + "  << Congelado por Nitrogeno >>");
                            listBox5.Items.Add(Vcongelado_nitro.datos[h].ToString());
                        }
                        else
                        {
                            listBox5.Items.Add(Vcongelado_nitro.datos[h].ToString());
                        }
                    }
                    break;

                case "Todo":
                    Todo();
                    break;

            }

        }
        public void Todo()
        {
            listBox1.Items.Add("Numero 1");
            listBox1.Items.Add("Fecha de Embazado: 13/05/2002");
            listBox1.Items.Add("Fecha de Caducidad: 13/12/2002");
            listBox1.Items.Add("Pais de Origen : Nicaragua");
            listBox1.Items.Add("Numero por Lote : 5");
            listBox1.Items.Add("Informacion Especifica : Manzana");
            listBox1.Items.Add("");
            listBox1.Items.Add("Numero 2");
            listBox1.Items.Add("Fecha de Embazado: 13/12/2005");
            listBox1.Items.Add("Fecha de Caducidad: 13/04/2006");
            listBox1.Items.Add("Pais de Origen : Mexico");
            listBox1.Items.Add("Numero por Lote : 5");
            listBox1.Items.Add("Informacion Especifica : Peras");
            listBox1.Items.Add("");
            listBox2.Items.Add("Numero 1");
            listBox2.Items.Add("Fecha de Embazado : 12/12/2012");
            listBox2.Items.Add("Fecha de Caducidad : 12/01/2014");
            listBox2.Items.Add("Codigo de supervicion alimentaria : 002-00s");
            listBox2.Items.Add("Temperatura Recomendada de Mantenimiento : 25g");
            listBox2.Items.Add("Pais de Origen : Costa Rica");
            listBox2.Items.Add("Numero por Lote : 15");
            listBox2.Items.Add("Informacion Especifica : Huevos");
            listBox2.Items.Add("");
            listBox2.Items.Add("Numero 2");
            listBox2.Items.Add("Fecha de Embazado : 12/12/2016");
            listBox2.Items.Add("Fecha de Caducidad : 12/01/2017");
            listBox2.Items.Add("Codigo de supervicion alimentaria : 002-01s");
            listBox2.Items.Add("Temperatura Recomendada de Mantenimiento : 15g");
            listBox2.Items.Add("Pais de Origen : Costa Marfil");
            listBox2.Items.Add("Numero por Lote : 13");
            listBox2.Items.Add("Informacion Especifica : Mantequilla");
            listBox2.Items.Add("");
            listBox3.Items.Add("Numero:  1");
            listBox3.Items.Add("Fecha de Embazado : 11/11/2011");
            listBox3.Items.Add("Fecha de Caducidad : 12/12/2012");
            listBox3.Items.Add("Pais de Origen : Cuba");
            listBox3.Items.Add("Numero Por Lote : 156");
            listBox3.Items.Add("Pocentaje de Nitrogeno : 1%");
            listBox3.Items.Add("Pocentaje de Dioxido De Carbono : 2%");
            listBox3.Items.Add("Pocentaje de Oxigeno : 3% ");
            listBox3.Items.Add("Pocentaje de Vapor de Agua :5% ");
            listBox3.Items.Add("Informacion Especifica : Nugets");
            listBox3.Items.Add("");
            listBox4.Items.Add("Numero : 1");
            listBox4.Items.Add("Fecha de Embazado : 5/05/2005");
            listBox4.Items.Add("Fecha de Caducidad : 6/06/2006");
            listBox4.Items.Add("Pais de Origen : Colombia");
            listBox4.Items.Add("Numero Por Lote : 12");
            listBox4.Items.Add("Salinidad del Agua : 2 gs/ltsA");
            listBox4.Items.Add("Informacion Especifica: Tomate");
            listBox4.Items.Add("");
            listBox5.Items.Add("Fecha de Embazado : 10/10/2010 ");
            listBox5.Items.Add("Fecha de Caducidad : 15/12/2015");
            listBox5.Items.Add("Pais de Origen : Venezuela ");
            listBox5.Items.Add("Numero por Lote : 25");
            listBox5.Items.Add("Informacion DEl Metodo : Cogelado al 100 ");
            listBox5.Items.Add("Tiempo De Exposicion : 1000S");
            listBox5.Items.Add("Informacion Especifica : nose");
            listBox5.Items.Add("");
            //frescos
            for (int d = 0; d < ventana_Pfrescos.cont; d++)
            {
                if (d % 6 == 0)
                {
                    s++;
                    listBox1.Items.Add("Numero :" + s);
                    listBox1.Items.Add(ventana_Pfrescos.datos[d].ToString());
                }
                else
                {
                    listBox1.Items.Add(ventana_Pfrescos.datos[d].ToString());
                }
            }
            //Refrigerados
            for (int i = 0; i < Ventana_Prefrigerados.cont; i++)
            {
                if (i % 8 == 0)
                {
                    x++;
                    listBox2.Items.Add("Producto Numero: " + "<" + x + ">");
                    listBox2.Items.Add(Ventana_Prefrigerados.Datos[i].ToString());
                }
                else
                {
                    listBox2.Items.Add(Ventana_Prefrigerados.Datos[i].ToString());
                }

            }

            // congelados por aire
            for (int q = 0; q < Vcongelado_Acs.cont; q++)
            {
                if (q % 11 == 0)
                {
                    z++;
                    listBox3.Items.Add("Numero :" + z + "  << Congelado por Aire >>");
                    listBox3.Items.Add(Vcongelado_Acs.datos[q].ToString());
                }
                else
                {
                    listBox3.Items.Add(Vcongelado_Acs.datos[q].ToString());
                }
            }
            //Congelados por Agua
            for (int it = 0; it < Vcongelado_agua.cont; it++)
            {
                if (it % 8 == 0)
                {
                    u++;
                    listBox4.Items.Add("Numero :" + u + "  << Congelado por Aire >>");
                    listBox4.Items.Add(Vcongelado_agua.datos[it].ToString());
                }
                else
                {
                    listBox4.Items.Add(Vcongelado_agua.datos[it].ToString());
                }
            }
            //Congelado por nitrogeno
            for (int h = 0; h < Vcongelado_nitro.cont; h++)
            {
                if (h % 9 == 0)
                {
                    w++;
                    listBox4.Items.Add("Numero :" + w + "  << Congelado por Aire >>");
                    listBox4.Items.Add(Vcongelado_nitro.datos[h].ToString());
                }
                else
                {
                    listBox4.Items.Add(Vcongelado_nitro.datos[h].ToString());
                }

            }
        }
    }
}
