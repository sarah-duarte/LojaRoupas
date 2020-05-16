using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmListaVenda : Form
    {
        CVenda cv = new CVenda();
        CItemVenda iv = new CItemVenda();
        public frmListaVenda()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            List<Venda> lista = cv.ListarVenda();
            foreach (Venda v in lista)
            {
                CCliente Cliente = new CCliente();
                COperador Operador = new COperador();

                ListViewItem item = new ListViewItem(v.getId().ToString());
                item.SubItems.Add(v.getData());
                item.SubItems.Add(v.getVlrTotal().ToString());
                item.SubItems.Add(v.getDesconto().ToString());
                item.SubItems.Add(v.getQtdItens().ToString());
                item.SubItems.Add(Cliente.GetNomeCliente(v.getIdCliente()));
                item.SubItems.Add(Operador.GetNomeOperador(v.getIdOperador()));
                lstListaVenda.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaVenda.Clear();
            lstListaVenda.View = View.Details;
            lstListaVenda.Columns.Add("ID", 30);
            lstListaVenda.Columns.Add("DATA", 76);
            lstListaVenda.Columns.Add("VALOR TOTAL", 87);
            lstListaVenda.Columns.Add("DESCONTO", 84);
            lstListaVenda.Columns.Add("QTD. ITENS", 74);
            lstListaVenda.Columns.Add("CLIENTE", 141);
            lstListaVenda.Columns.Add("OPERADOR", 125);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            cv.TelaVenda();
            MontaLista();
            AtualizaLista();
        }
        private void frmListaVenda_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void btnItensDoc_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection documentoSelect =
                this.lstListaVenda.SelectedItems;

            foreach (ListViewItem item in documentoSelect)
            {
                iv.TelaItemVenda(iv.ListarItemVenda(int.Parse(item.SubItems[0].Text)));
            }
        }
    }
}