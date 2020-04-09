using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;

namespace LojaRoupas
{
    public partial class frmVenda : Form
    {
        List<ItemVenda> itensVenda = new List<ItemVenda>();
        Venda venda = new Venda();
        
        public frmVenda()
        {
            InitializeComponent();
        }

        private void MontaLista()
        {
            lstListaItensVenda.Clear();
            lstListaItensVenda.View = View.Details;
            lstListaItensVenda.Columns.Add("CÓDIGO", 66);
            lstListaItensVenda.Columns.Add("DESCRIÇÃO", 265);
            lstListaItensVenda.Columns.Add("PREÇO", 70);
            lstListaItensVenda.Columns.Add("QTDE", 70);
            lstListaItensVenda.Columns.Add("TOTAL", 76);
        }

        private void AddItemLista(Produto prod)
        {
            ItemVenda itemV = new ItemVenda();
            itemV.setID(itemV.NovoId());
            itemV.setIdDocumento(int.Parse(lblID.Text));
            itemV.setIdProduto(prod.getIdProduto());
            itemV.setQtdItens(int.Parse(txtQtd.Text));
            itemV.setPrcVenda(prod.getPrecoVenda());
            itemV.setTotalPreco(prod.getPrecoVenda() * int.Parse(txtQtd.Text));
            itensVenda.Add(itemV);
        }

        private Double GetTotalProdutos()
        {
            Double TotalProduto = 0;
            foreach (ItemVenda itV in itensVenda)
            {
                Console.WriteLine("{0}", itV.getId().ToString());
                TotalProduto += itV.getTotalPreco();
            }
            return TotalProduto;
        }
        private int GetTotalQtdItens()
        {
            int TotalQtdItens = 0;
            foreach (ItemVenda itV in itensVenda)
            {
                Console.WriteLine("{0}", itV.getId().ToString());
                TotalQtdItens += itV.getQtdItens();
            }
            return TotalQtdItens;
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = produto.getProduto(txtCodBarras.Text);
            Console.WriteLine("{0}", produto.getIdProduto().ToString());
            ListViewItem item = new ListViewItem(produto.getCodigoBarras());
            item.SubItems.Add(produto.getDescProduto() +" "+ produto.getCorProduto() +" "+ produto.getTamProduto());
            item.SubItems.Add(produto.getPrecoVenda().ToString());
            item.SubItems.Add(txtQtd.Text);
            item.SubItems.Add((produto.getPrecoVenda()* int.Parse(txtQtd.Text)).ToString());
            lstListaItensVenda.Items.Add(item);

            AddItemLista(produto);
            lblTotal.Text = "R$ " + GetTotalProdutos().ToString();
            lblQtdItens.Text = GetTotalQtdItens().ToString();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            lblID.Text = Convert.ToString(venda.NovoId());
            MontaLista();
        }
    }
}
