using System;
using System.Windows.Forms;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmPrincipal : Form
    {
        CCliente c = new CCliente();
        CFornecedor f = new CFornecedor();
        COperador o = new COperador();
        CUsuario u = new CUsuario();
        CProduto p = new CProduto();
        CVenda v = new CVenda();
        CCompra cm = new CCompra();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e) => p.TelaListaProduto();
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) => c.TelaListaCliente();
        private void operadorToolStripMenuItem_Click(object sender, EventArgs e) => o.TelaListaOperador();
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e) => f.TelaListaFornecedor();
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e) => u.TelaListaUsuario();
        private void vendaToolStripMenuItem_Click(object sender, EventArgs e) => v.TelaListaVenda();
        private void compraToolStripMenuItem_Click(object sender, EventArgs e) => cm.TelaListaCompra();
    }
}