using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;

namespace LojaRoupas
{
    public partial class frmListaItensVenda : Form
    {
        private List<ItemVenda> lista = new List<ItemVenda>();

        internal List<ItemVenda> Lista { get => lista; set => lista = value; }

        public frmListaItensVenda()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            foreach (ItemVenda i in Lista)
            {
                //Console.WriteLine("{0}", i.getId().ToString());
                Produto Produto = new Produto();

                ListViewItem item = new ListViewItem(i.getId().ToString());
                item.SubItems.Add(Produto.GetDescProduto(i.getIdProduto()));
                item.SubItems.Add(i.GetPrcVenda().ToString());
                item.SubItems.Add(i.getQtdItens().ToString());
                item.SubItems.Add(i.getTotalPreco().ToString());
                lstListaItensVenda.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaItensVenda.Clear();
            lstListaItensVenda.View = View.Details;
            lstListaItensVenda.Columns.Add("ID", 30);
            lstListaItensVenda.Columns.Add("PRODUTO", 250);
            lstListaItensVenda.Columns.Add("VLR VENDA", 87);
            lstListaItensVenda.Columns.Add("QTD", 84);
            lstListaItensVenda.Columns.Add("TOTAL", 74);
        }
        private void frmListaItensVenda_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
    }
}
