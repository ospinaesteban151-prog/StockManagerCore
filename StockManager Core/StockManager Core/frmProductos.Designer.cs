namespace StockManager_Core
{
    partial class frmProductos
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
            dgvProductos = new DataGridView();
            BtnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboxCategoria = new ComboBox();
            txtNombreProducto = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            BtnModificarStock = new Button();
            BtnEliminar = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            stockBajoToolStripMenuItem = new ToolStripMenuItem();
            valoraToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(53, 262);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(860, 316);
            dgvProductos.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(53, 197);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(107, 39);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 39);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 121);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 4;
            label2.Text = "Stock Disponible:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 121);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 5;
            label3.Text = "Precio Unitario ($):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 38);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Categoria:";
            // 
            // cboxCategoria
            // 
            cboxCategoria.FormattingEnabled = true;
            cboxCategoria.Location = new Point(529, 61);
            cboxCategoria.Name = "cboxCategoria";
            cboxCategoria.Size = new Size(369, 28);
            cboxCategoria.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(53, 62);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(369, 27);
            txtNombreProducto.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(53, 144);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(369, 27);
            txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(529, 144);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(369, 27);
            txtStock.TabIndex = 10;
            // 
            // BtnModificarStock
            // 
            BtnModificarStock.Location = new Point(176, 197);
            BtnModificarStock.Name = "BtnModificarStock";
            BtnModificarStock.Size = new Size(137, 39);
            BtnModificarStock.TabIndex = 11;
            BtnModificarStock.Text = "Modificar Stock";
            BtnModificarStock.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(332, 197);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(110, 39);
            BtnEliminar.TabIndex = 12;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, gestionToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(954, 28);
            menuStrip1.TabIndex = 13;
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
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 590);
            Controls.Add(menuStrip1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificarStock);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreProducto);
            Controls.Add(cboxCategoria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnGuardar);
            Controls.Add(dgvProductos);
            Name = "frmProductos";
            Text = "Inventario Activo";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button BtnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboxCategoria;
        private TextBox txtNombreProducto;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button BtnModificarStock;
        private Button BtnEliminar;
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