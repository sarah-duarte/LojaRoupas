using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;

namespace LojaRoupas
{
    public partial class frmListaCompra : Form
    {
        public frmListaCompra()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            Compra Compra = new Compra();
            List<Compra> lista = Compra.ListaCompra();
            foreach (Compra v in lista)
            {
                Console.WriteLine("{0}", Compra.getId().ToString());
                Fornecedor Fornecedor = new Fornecedor();

                ListViewItem item = new ListViewItem(v.getId().ToString());
                item.SubItems.Add(v.getData());
                item.SubItems.Add(v.getVlrTotal().ToString());
                item.SubItems.Add(v.getDesconto().ToString());
                item.SubItems.Add(v.getQtdItens().ToString());
                item.SubItems.Add(Fornecedor.getNomeFornecedor(v.getIdFornecedor()));
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
            frmCompra telaCompra = new frmCompra();
            telaCompra.ShowDialog();
            MontaLista();
            AtualizaLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void frmListaCompra_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
    }
}
