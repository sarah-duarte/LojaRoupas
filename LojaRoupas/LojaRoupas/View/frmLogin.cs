using System;
using System.Windows.Forms;

namespace LojaRoupas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrincipal telaPrincipal = new frmPrincipal();
            telaPrincipal.ShowDialog();
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}