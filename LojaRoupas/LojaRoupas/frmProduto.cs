using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LojaRoupas.Classes; 

namespace LojaRoupas
{
    public partial class frmProduto : Form
    {
        Produto produto = new Produto();
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            produto.setIdProduto(int.Parse(lblID.Text));
            produto.setCodigoBarras(txtCodBarras.Text);
            produto.setDescProduto(txtDescricao.Text);
            produto.setCorProduto(txtCor.Text);
            produto.setTamProduto(txtTamanho.Text);
            produto.setPrecoCusto(Double.Parse(txtPrcCusto.Text));
            produto.setPrecoVenda(Double.Parse(txtPrcVenda.Text));
            produto.setQtdEstProduto(int.Parse(txtQtdEstoque.Text));
            try{
                produto.cadProduto(produto);
                MessageBox.Show("Produto Cadastrado com Sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            lblID.Text = Convert.ToString(produto.NovoId());
        }
    }
}
