using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmListaCompra : Form
    {
        CCompra cm = new CCompra();
        CItemCompra ic = new CItemCompra();
        public frmListaCompra()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            List<Compra> lista = cm.ListarCompra();
            foreach (Compra v in lista)
            {
                CFornecedor Fornecedor = new CFornecedor();
                ListViewItem item = new ListViewItem(v.getId().ToString());
                item.SubItems.Add(v.getData());
                item.SubItems.Add(v.getVlrTotal().ToString());
                item.SubItems.Add(v.getDesconto().ToString());
                item.SubItems.Add(v.getQtdItens().ToString());
                item.SubItems.Add(Fornecedor.GetNomeFornecedor(v.getIdFornecedor()));
                lstListaCompra.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaCompra.Clear();
            lstListaCompra.View = View.Details;
            lstListaCompra.Columns.Add("ID", 30);
            lstListaCompra.Columns.Add("DATA", 76);
            lstListaCompra.Columns.Add("VALOR TOTAL", 87);
            lstListaCompra.Columns.Add("DESCONTO", 84);
            lstListaCompra.Columns.Add("QTD. ITENS", 74);
            lstListaCompra.Columns.Add("FORNECEDOR", 164);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            cm.TelaCompra();
            MontaLista();
            AtualizaLista();
        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();
        private void frmListaCompra_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
        private void btnItensDoc_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection documentoSelect =
                this.lstListaCompra.SelectedItems;

            foreach (ListViewItem item in documentoSelect)
            {
                ic.TelaItemCompra(ic.ListarItemCompra(int.Parse(item.SubItems[0].Text)));
            }
        }
    }
}
