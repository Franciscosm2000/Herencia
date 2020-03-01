namespace Trabajo_con_herencia
{
    partial class testHerencia3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frescosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrigeradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congeladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congeladosPorAireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congeladosPorAguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congeladosPorNitrogenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosFrescosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosCongeladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosCongeladosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.mostrarInformacionToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frescosToolStripMenuItem,
            this.refrigeradosToolStripMenuItem,
            this.congeladosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // frescosToolStripMenuItem
            // 
            this.frescosToolStripMenuItem.Name = "frescosToolStripMenuItem";
            this.frescosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frescosToolStripMenuItem.Text = "Frescos";
            this.frescosToolStripMenuItem.Click += new System.EventHandler(this.frescosToolStripMenuItem_Click);
            // 
            // refrigeradosToolStripMenuItem
            // 
            this.refrigeradosToolStripMenuItem.Name = "refrigeradosToolStripMenuItem";
            this.refrigeradosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refrigeradosToolStripMenuItem.Text = "Refrigerados";
            this.refrigeradosToolStripMenuItem.Click += new System.EventHandler(this.refrigeradosToolStripMenuItem_Click);
            // 
            // congeladosToolStripMenuItem
            // 
            this.congeladosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.congeladosPorAireToolStripMenuItem,
            this.congeladosPorAguaToolStripMenuItem,
            this.congeladosPorNitrogenoToolStripMenuItem});
            this.congeladosToolStripMenuItem.Name = "congeladosToolStripMenuItem";
            this.congeladosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.congeladosToolStripMenuItem.Text = "Congelados";
            // 
            // congeladosPorAireToolStripMenuItem
            // 
            this.congeladosPorAireToolStripMenuItem.Name = "congeladosPorAireToolStripMenuItem";
            this.congeladosPorAireToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.congeladosPorAireToolStripMenuItem.Text = "Congelados Por Aire";
            this.congeladosPorAireToolStripMenuItem.Click += new System.EventHandler(this.congeladosPorAireToolStripMenuItem_Click);
            // 
            // congeladosPorAguaToolStripMenuItem
            // 
            this.congeladosPorAguaToolStripMenuItem.Name = "congeladosPorAguaToolStripMenuItem";
            this.congeladosPorAguaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.congeladosPorAguaToolStripMenuItem.Text = "Congelados Por Agua";
            this.congeladosPorAguaToolStripMenuItem.Click += new System.EventHandler(this.congeladosPorAguaToolStripMenuItem_Click);
            // 
            // congeladosPorNitrogenoToolStripMenuItem
            // 
            this.congeladosPorNitrogenoToolStripMenuItem.Name = "congeladosPorNitrogenoToolStripMenuItem";
            this.congeladosPorNitrogenoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.congeladosPorNitrogenoToolStripMenuItem.Text = "Congelados Por Nitrogeno";
            this.congeladosPorNitrogenoToolStripMenuItem.Click += new System.EventHandler(this.congeladosPorNitrogenoToolStripMenuItem_Click);
            // 
            // mostrarInformacionToolStripMenuItem
            // 
            this.mostrarInformacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosFrescosToolStripMenuItem,
            this.productosCongeladosToolStripMenuItem,
            this.productosCongeladosToolStripMenuItem1,
            this.todosToolStripMenuItem});
            this.mostrarInformacionToolStripMenuItem.Name = "mostrarInformacionToolStripMenuItem";
            this.mostrarInformacionToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.mostrarInformacionToolStripMenuItem.Text = "Mostrar Informacion";
            this.mostrarInformacionToolStripMenuItem.Click += new System.EventHandler(this.mostrarInformacionToolStripMenuItem_Click);
            // 
            // productosFrescosToolStripMenuItem
            // 
            this.productosFrescosToolStripMenuItem.Name = "productosFrescosToolStripMenuItem";
            this.productosFrescosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.productosFrescosToolStripMenuItem.Text = "Productos Frescos";
            this.productosFrescosToolStripMenuItem.Click += new System.EventHandler(this.productosFrescosToolStripMenuItem_Click);
            // 
            // productosCongeladosToolStripMenuItem
            // 
            this.productosCongeladosToolStripMenuItem.Name = "productosCongeladosToolStripMenuItem";
            this.productosCongeladosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.productosCongeladosToolStripMenuItem.Text = "Productos Refrigerados";
            this.productosCongeladosToolStripMenuItem.Click += new System.EventHandler(this.productosCongeladosToolStripMenuItem_Click);
            // 
            // productosCongeladosToolStripMenuItem1
            // 
            this.productosCongeladosToolStripMenuItem1.Name = "productosCongeladosToolStripMenuItem1";
            this.productosCongeladosToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.productosCongeladosToolStripMenuItem1.Text = "Productos Congelados";
            this.productosCongeladosToolStripMenuItem1.Click += new System.EventHandler(this.productosCongeladosToolStripMenuItem1_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // testHerencia3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "testHerencia3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.testHerencia3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frescosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrigeradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congeladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congeladosPorAireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congeladosPorAguaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congeladosPorNitrogenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarInformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosFrescosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosCongeladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosCongeladosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

