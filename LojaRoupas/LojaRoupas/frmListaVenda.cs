using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;

namespace LojaRoupas
{
    public partial class frmListaVenda : Form
    {
        public frmListaVenda()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            Venda venda = new Venda();
            List<Venda> lista = venda.ListaVenda();
            foreach (Venda v in lista)
            {
                Console.WriteLine("{0}", venda.getId().ToString());
                Cliente Cliente = new Cliente();
                Operador Operador = new Operador();

                ListViewItem item = new ListViewItem(v.getId().ToString());
                item.SubItems.Add(v.getData());
                item.SubItems.Add(v.getVlrTotal().ToString());
                item.SubItems.Add(v.getDesconto().ToString());
                item.SubItems.Add(v.getQtdItens().ToString());
                item.SubItems.Add(Cliente.getNomeCliente(v.getIdCliente()));
                item.SubItems.Add(Operador.getNomeOperador(v.getIdOperador()));
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
            frmVenda telaVenda = new frmVenda();
            telaVenda.ShowDialog();
            MontaLista();
            AtualizaLista();
        }
        private void frmListaVenda_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
