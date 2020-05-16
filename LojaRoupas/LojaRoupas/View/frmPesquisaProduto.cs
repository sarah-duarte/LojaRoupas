using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmPesquisaProduto : Form
    {
        CProduto cProduto = new CProduto();

        internal Produto Produto { get; set; } = new Produto();

        public frmPesquisaProduto()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            double PrcCusto = 0;
            double PrcVenda = 0;
            if (txtPrcCusto.Text != String.Empty) PrcCusto = Double.Parse(txtPrcCusto.Text);
            if (txtPrcVenda.Text != String.Empty) PrcVenda = Double.Parse(txtPrcVenda.Text);

            List<Produto> lista = cProduto.ListarProduto(txtCodBarras.Text, txtDescricao.Text, txtCor.Text, txtTamanho.Text, PrcCusto, PrcVenda);
            foreach (Produto p in lista)
            {
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
        private void btnPesq_Click(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
            this.lstListaProduto.Items[0].Focused = true;
            this.lstListaProduto.Items[0].Selected = true;
        }
        private void lstListaProduto_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection produtoSelect =
                this.lstListaProduto.SelectedItems;

            foreach (ListViewItem item in produtoSelect)
            {
                Produto = cProduto.GetProduto(item.SubItems[1].Text);
                Close();
            }
        }
    }
}