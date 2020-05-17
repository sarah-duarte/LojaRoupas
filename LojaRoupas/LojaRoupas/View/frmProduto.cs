using System;
using System.Windows.Forms;
using System.IO;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmProduto : Form
    {
        CProduto p = new CProduto();
        private Produto produto = new Produto();
        internal Produto Produto { get => produto; set => produto = value; }
        public frmProduto()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto.setIdProduto(int.Parse(lblID.Text));
            Produto.setCodigoBarras(txtCodBarras.Text);
            Produto.setDescProduto(txtDescricao.Text);
            Produto.setCorProduto(txtCor.Text);
            Produto.setTamProduto(txtTamanho.Text);
            Produto.setPrecoCusto(Double.Parse(txtPrcCusto.Text));
            Produto.setPrecoVenda(Double.Parse(txtPrcVenda.Text));
            Produto.setQtdEstProduto(int.Parse(txtQtdEstoque.Text));
            try{
                p.SalvarProduto(Produto);
                MessageBox.Show("Produto Salvo com Sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
        private void frmProduto_Load(object sender, EventArgs e)
        {
            if (Produto.getIdProduto() != 0)
            {
                lblID.Text = Produto.getIdProduto().ToString();
                txtCodBarras.Text = Produto.getCodigoBarras();
                txtDescricao.Text = Produto.getDescProduto();
                txtCor.Text = Produto.getCorProduto();
                txtTamanho.Text = Produto.getTamProduto();
                txtPrcCusto.Text = Produto.getPrecoCusto().ToString();
                txtPrcVenda.Text = Produto.getPrecoVenda().ToString();
                txtQtdEstoque.Text = Produto.getQtdEstProduto().ToString();             
                txtQtdEstoque.Enabled = false;
            }
            else
            {
                lblID.Text = Convert.ToString(p.NovoId());
                lblQtdEstoque.Visible = false;
                txtQtdEstoque.Visible = false;
            }
        }
    }
}
