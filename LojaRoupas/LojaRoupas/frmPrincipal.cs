using System;
using System.Windows.Forms;
using System.Drawing;

namespace LojaRoupas
{
    public partial class frmPrincipal : Form
    {
  
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_SizaChanged(object sender, EventArgs e)
        {
            this.ArrangeFormSize();
            this.ArrangeFormSizeP();
            this.ArrangeFormSizeC();
            this.ArrangeFormSizeF();
            this.ArrangeFormSizeU();
            this.ArrangeFormSizeV();
            
        }
        private frmListaProdutos abreProduto = null;
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abreProduto = new frmListaProdutos();
            this.abreProduto.TopLevel = false;
            this.abreProduto.Visible = true;
            this.Controls.Add(this.abreProduto);
            this.ArrangeFormSizeP();
        }
        private void ArrangeFormSizeP()
        {
            this.abreProduto.Location = new Point(
                this.ClientSize.Width - this.abreProduto.Width,
                this.ClientSize.Height - this.abreProduto.Height + 16
                );
        }

        private frmListaCliente abreCliente = null;
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abreCliente = new frmListaCliente();
            this.abreCliente.TopLevel = false;
            this.abreCliente.Visible = true;
            this.Controls.Add(this.abreCliente);
            this.ArrangeFormSizeC();
        }
        private void ArrangeFormSizeC()
        {
            this.abreCliente.Location = new Point(
                this.ClientSize.Width - this.abreCliente.Width,
                this.ClientSize.Height - this.abreCliente.Height + 16
                );
        }

        private frmListaOperador abreOperador = null;
        private void operadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abreOperador = new frmListaOperador();
            this.abreOperador.TopLevel = false;
            this.abreOperador.Visible = true;
            this.Controls.Add(this.abreOperador);
            this.ArrangeFormSize();

        }

        private void ArrangeFormSize()
        { 
            this.abreOperador.Location = new Point (
                this.ClientSize.Width - this.abreOperador.Width,
                this.ClientSize.Height - this.abreOperador.Height + 16
                );
        }

        private frmListaFornecedor abreFornecedor = null;
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.abreFornecedor = new frmListaFornecedor();
            this.abreFornecedor.TopLevel = false;
            this.abreFornecedor.Visible = true;
            this.Controls.Add(this.abreFornecedor);
            this.ArrangeFormSizeF();
        }

        private void ArrangeFormSizeF()
        {
            this.abreFornecedor.Location = new Point(
                this.ClientSize.Width - this.abreFornecedor.Width,
                this.ClientSize.Height - this.abreFornecedor.Height + 16
                );
        }

        private frmUsuarios abreUsuarios = null;
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abreUsuarios = new frmUsuarios();
            this.abreUsuarios.TopLevel = false;
            this.abreUsuarios.Visible = true;
            this.Controls.Add(this.abreUsuarios);
            this.ArrangeFormSizeU();
        }
        private void ArrangeFormSizeU()
        {
            this.abreUsuarios.Location = new Point(
                this.ClientSize.Width - this.abreUsuarios.Width,
                this.ClientSize.Height - this.abreUsuarios.Height + 16
                );
        }

        private frmVenda abreVenda = null;
        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abreVenda = new frmVenda();
            this.abreVenda.TopLevel = false;
            this.abreVenda.Visible = true;
            this.Controls.Add(this.abreVenda);
            this.ArrangeFormSizeV();
        }
        private void ArrangeFormSizeV()
        {
            this.abreVenda.Location = new Point(
                this.ClientSize.Width - this.abreVenda.Width,
                this.ClientSize.Height - this.abreVenda.Height + 16
                );
        }
    }
}