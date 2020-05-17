using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmListaItensCompra : Form
    {
        private List<ItemCompra> lista = new List<ItemCompra>();
        internal List<ItemCompra> Lista { get => lista; set => lista = value; }
        public frmListaItensCompra()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            foreach (ItemCompra i in Lista)
            {
                CProduto Produto = new CProduto();
                ListViewItem item = new ListViewItem(i.getId().ToString());
                item.SubItems.Add(Produto.GetDescProduto(i.getIdProduto()));
                item.SubItems.Add(i.getPrcCusto().ToString());
                item.SubItems.Add(i.getQtdItens().ToString());
                item.SubItems.Add(i.getTotalPreco().ToString());
                lstListaItensCompra.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaItensCompra.Clear();
            lstListaItensCompra.View = View.Details;
            lstListaItensCompra.Columns.Add("ID", 30);
            lstListaItensCompra.Columns.Add("PRODUTO", 250);
            lstListaItensCompra.Columns.Add("VLR CUSTO", 87);
            lstListaItensCompra.Columns.Add("QTD", 84);
            lstListaItensCompra.Columns.Add("TOTAL", 74);
        }
        private void frmListaItensCompra_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
    }
}
