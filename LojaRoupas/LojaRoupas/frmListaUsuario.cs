using System;
using System.Windows.Forms;

namespace LojaRoupas
{
    public partial class frmListaUsuario : Form
    {
        public frmListaUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmUsuarios telaUsuarios = new frmUsuarios();
            telaUsuarios.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
