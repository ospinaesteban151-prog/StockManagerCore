namespace StockManager_Core
{
    partial class frmReportes
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
            btnStock = new Button();
            dgvReportes = new DataGridView();
            label1 = new Label();
            btnValorizacionInventario = new Button();
            btnExportar = new Button();
            lblTotalValorizacion = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            stockBajoToolStripMenuItem = new ToolStripMenuItem();
            valoraToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.Location = new Point(34, 47);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(131, 57);
            btnStock.TabIndex = 0;
            btnStock.Text = "Stock Bajo";
            btnStock.UseVisualStyleBackColor = true;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(34, 131);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(726, 285);
            dgvReportes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 446);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 2;
            label1.Text = "Total Valorarizacion:";
            // 
            // btnValorizacionInventario
            // 
            btnValorizacionInventario.Location = new Point(191, 47);
            btnValorizacionInventario.Name = "btnValorizacionInventario";
            btnValorizacionInventario.Size = new Size(180, 57);
            btnValorizacionInventario.TabIndex = 3;
            btnValorizacionInventario.Text = "Valorizacion del Inventario";
            btnValorizacionInventario.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(396, 47);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(131, 57);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // lblTotalValorizacion
            // 
            lblTotalValorizacion.AutoSize = true;
            lblTotalValorizacion.Location = new Point(183, 446);
            lblTotalValorizacion.Name = "lblTotalValorizacion";
            lblTotalValorizacion.Size = new Size(44, 20);
            lblTotalValorizacion.TabIndex = 5;
            lblTotalValorizacion.Text = "$0.00";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, gestionToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, productosToolStripMenuItem });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(73, 24);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(163, 26);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(163, 26);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stockBajoToolStripMenuItem, valoraToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // stockBajoToolStripMenuItem
            // 
            stockBajoToolStripMenuItem.Name = "stockBajoToolStripMenuItem";
            stockBajoToolStripMenuItem.Size = new Size(268, 26);
            stockBajoToolStripMenuItem.Text = "Stock Bajo";
            // 
            // valoraToolStripMenuItem
            // 
            valoraToolStripMenuItem.Name = "valoraToolStripMenuItem";
            valoraToolStripMenuItem.Size = new Size(268, 26);
            valoraToolStripMenuItem.Text = "Valorizacion del Inventario";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(menuStrip1);
            Controls.Add(lblTotalValorizacion);
            Controls.Add(btnExportar);
            Controls.Add(btnValorizacionInventario);
            Controls.Add(label1);
            Controls.Add(dgvReportes);
            Controls.Add(btnStock);
            Name = "frmReportes";
            Text = "Reportes Analiticos";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStock;
        private DataGridView dgvReportes;
        private Label label1;
        private Button btnValorizacionInventario;
        private Button btnExportar;
        private Label lblTotalValorizacion;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem stockBajoToolStripMenuItem;
        private ToolStripMenuItem valoraToolStripMenuItem;
    }
}