using System;
using System.Windows.Forms;

namespace LojaRoupas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaProdutos telaListaProduto = new frmListaProdutos();
            telaListaProduto.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente telaCliente = new frmCliente();
            telaCliente.ShowDialog();
        }

        private void operadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperador telaOperador = new frmOperador();
            telaOperador.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios telaUsuarios = new frmUsuarios();
            telaUsuarios.ShowDialog();   
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda telaVenda = new frmVenda();
            telaVenda.ShowDialog();
        }
    }
}