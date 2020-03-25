using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaRoupas.Classes; 

namespace LojaRoupas
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.setIdProduto(int.Parse(lblID.Text));
            produto.setCodigoBarras(txtCodBarras.Text);
            produto.setDescProduto(txtDescricao.Text);
            produto.setCorProduto(txtCor.Text);
            produto.setTamProduto(txtTamanho.Text);
            produto.setPrecoCusto(float.Parse(txtPrcCusto.Text));
            produto.setPrecoVenda(float.Parse(txtPrcVenda.Text));
            produto.setQtdEstProduto(int.Parse(txtQtdEstoque.Text));
        }
    }
}
