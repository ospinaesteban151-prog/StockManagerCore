namespace StockManager_Core
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        // ===== ARCHIVO =====
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // ===== GESTIÓN =====
        //  Categorias
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


    }
}
