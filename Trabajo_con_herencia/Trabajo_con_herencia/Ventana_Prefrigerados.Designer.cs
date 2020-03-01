namespace Trabajo_con_herencia
{
    partial class Ventana_Prefrigerados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_embazado = new System.Windows.Forms.DateTimePicker();
            this.CODSA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.TextBox();
            this.pais_origen = new System.Windows.Forms.TextBox();
            this.numero_por_lotes = new System.Windows.Forms.TextBox();
            this.informacion_especi = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Embazado :";
            // 
            // fecha_embazado
            // 
            this.fecha_embazado.Location = new System.Drawing.Point(146, 27);
            this.fecha_embazado.Name = "fecha_embazado";
            this.fecha_embazado.Size = new System.Drawing.Size(208, 20);
            this.fecha_embazado.TabIndex = 1;
            // 
            // CODSA
            // 
            this.CODSA.Location = new System.Drawing.Point(146, 102);
            this.CODSA.Name = "CODSA";
            this.CODSA.Size = new System.Drawing.Size(115, 20);
            this.CODSA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Caducidad  :";
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.Location = new System.Drawing.Point(146, 70);
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.Size = new System.Drawing.Size(208, 20);
            this.fecha_vencimiento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " CODSA :\r\n";
            this.toolTip1.SetToolTip(this.label3, "Codigo De Organismo De Supervicion Alimentaria\r\n");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Temperatura DMR :\r\n";
            this.toolTip1.SetToolTip(this.label4, "Temperatura de Matenimiento Recomendada\r\n");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pais de Origen :\r\n";
            this.toolTip1.SetToolTip(this.label5, "Codigo De Organismo De Supervicion Alimentaria\r\n");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Informacion Especifica  :\r\n";
            this.toolTip1.SetToolTip(this.label6, "Codigo De Organismo De Supervicion Alimentaria\r\n");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Numero Por Lotes  :\r\n";
            this.toolTip1.SetToolTip(this.label7, "Codigo De Organismo De Supervicion Alimentaria\r\n");
            // 
            // temperatura
            // 
            this.temperatura.Location = new System.Drawing.Point(146, 132);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(115, 20);
            this.temperatura.TabIndex = 7;
            // 
            // pais_origen
            // 
            this.pais_origen.Location = new System.Drawing.Point(146, 163);
            this.pais_origen.Name = "pais_origen";
            this.pais_origen.Size = new System.Drawing.Size(115, 20);
            this.pais_origen.TabIndex = 9;
            // 
            // numero_por_lotes
            // 
            this.numero_por_lotes.Location = new System.Drawing.Point(146, 197);
            this.numero_por_lotes.Name = "numero_por_lotes";
            this.numero_por_lotes.Size = new System.Drawing.Size(115, 20);
            this.numero_por_lotes.TabIndex = 12;
            // 
            // informacion_especi
            // 
            this.informacion_especi.Location = new System.Drawing.Point(146, 229);
            this.informacion_especi.Multiline = true;
            this.informacion_especi.Name = "informacion_especi";
            this.informacion_especi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.informacion_especi.Size = new System.Drawing.Size(115, 40);
            this.informacion_especi.TabIndex = 13;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 341);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(562, 147);
            this.lista.TabIndex = 14;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(14, 285);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(71, 27);
            this.Agregar.TabIndex = 15;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            this.Agregar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Agregar_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ventana_Prefrigerados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.informacion_especi);
            this.Controls.Add(this.numero_por_lotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pais_origen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_vencimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CODSA);
            this.Controls.Add(this.fecha_embazado);
            this.Controls.Add(this.label1);
            this.Name = "Ventana_Prefrigerados";
            this.Text = "Ventana_Prefrigerados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_embazado;
        private System.Windows.Forms.TextBox CODSA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha_vencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox temperatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pais_origen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numero_por_lotes;
        private System.Windows.Forms.TextBox informacion_especi;
        private System.Windows.Forms.Button Agregar;
        public System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button button1;
    }
}