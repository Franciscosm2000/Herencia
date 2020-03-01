namespace Trabajo_con_herencia
{
    partial class ventana_Pfrescos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pais_origen = new System.Windows.Forms.TextBox();
            this.numero_por_lote = new System.Windows.Forms.TextBox();
            this.informacion_especifica = new System.Windows.Forms.TextBox();
            this.fecha_embazado = new System.Windows.Forms.DateTimePicker();
            this.Fecha_caducidad = new System.Windows.Forms.DateTimePicker();
            this.lista = new System.Windows.Forms.ListBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Enbazado :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pais de Origen :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Caducidad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero por Lote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Informacion Especifica :";
            // 
            // Pais_origen
            // 
            this.Pais_origen.Location = new System.Drawing.Point(155, 64);
            this.Pais_origen.Name = "Pais_origen";
            this.Pais_origen.Size = new System.Drawing.Size(100, 20);
            this.Pais_origen.TabIndex = 6;
            // 
            // numero_por_lote
            // 
            this.numero_por_lote.Location = new System.Drawing.Point(155, 149);
            this.numero_por_lote.Name = "numero_por_lote";
            this.numero_por_lote.Size = new System.Drawing.Size(46, 20);
            this.numero_por_lote.TabIndex = 8;
            // 
            // informacion_especifica
            // 
            this.informacion_especifica.Location = new System.Drawing.Point(155, 186);
            this.informacion_especifica.Multiline = true;
            this.informacion_especifica.Name = "informacion_especifica";
            this.informacion_especifica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.informacion_especifica.Size = new System.Drawing.Size(153, 71);
            this.informacion_especifica.TabIndex = 9;
            this.informacion_especifica.TextChanged += new System.EventHandler(this.informacion_especifica_TextChanged);
            // 
            // fecha_embazado
            // 
            this.fecha_embazado.Location = new System.Drawing.Point(155, 25);
            this.fecha_embazado.Name = "fecha_embazado";
            this.fecha_embazado.Size = new System.Drawing.Size(200, 20);
            this.fecha_embazado.TabIndex = 10;
            // 
            // Fecha_caducidad
            // 
            this.Fecha_caducidad.Location = new System.Drawing.Point(155, 107);
            this.Fecha_caducidad.Name = "Fecha_caducidad";
            this.Fecha_caducidad.Size = new System.Drawing.Size(200, 20);
            this.Fecha_caducidad.TabIndex = 11;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(22, 324);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(437, 147);
            this.lista.TabIndex = 12;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(22, 283);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 13;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aseptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventana_Pfrescos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.Fecha_caducidad);
            this.Controls.Add(this.fecha_embazado);
            this.Controls.Add(this.informacion_especifica);
            this.Controls.Add(this.numero_por_lote);
            this.Controls.Add(this.Pais_origen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ventana_Pfrescos";
            this.Text = "ventana_Pfrescos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pais_origen;
        private System.Windows.Forms.TextBox numero_por_lote;
        private System.Windows.Forms.TextBox informacion_especifica;
        private System.Windows.Forms.DateTimePicker fecha_embazado;
        private System.Windows.Forms.DateTimePicker Fecha_caducidad;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button button1;
    }
}