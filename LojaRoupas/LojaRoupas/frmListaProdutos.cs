using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;

namespace LojaRoupas
{
    public partial class frmListaProdutos : Form
    {
        public frmListaProdutos()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            Produto produto = new Produto();
            List<Produto> lista = produto.ListaProduto();
            foreach (Produto p in lista)
            {
                //Console.WriteLine("{0}", p.getIdProduto().ToString());
                ListViewItem item = new ListViewItem(p.getIdProduto().ToString());
                item.SubItems.Add(p.getCodigoBarras());
                item.SubItems.Add(p.getDescProduto());
                item.SubItems.Add(p.getCorProduto());
                item.SubItems.Add(p.getTamProduto());
                item.SubItems.Add(p.getPrecoCusto().ToString());
                item.SubItems.Add(p.getPrecoVenda().ToString());
                item.SubItems.Add(p.getQtdEstProduto().ToString());
                lstListaProduto.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaProduto.Clear();
            lstListaProduto.View = View.Details;
            lstListaProduto.Columns.Add("ID", 30);
            lstListaProduto.Columns.Add("CODIGO BARRAS", 103);
            lstListaProduto.Columns.Add("DESCRIÇÃO", 146);
            lstListaProduto.Columns.Add("COR", 84);
            lstListaProduto.Columns.Add("TAMANHO", 60);
            lstListaProduto.Columns.Add("CUSTO", 70);
            lstListaProduto.Columns.Add("VENDA", 77);
            lstListaProduto.Columns.Add("ESTOQUE", 60);
        }
        private void frmListaProdutos_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmProduto telaProduto = new frmProduto();
            telaProduto.ShowDialog();
            MontaLista();
            AtualizaLista();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}