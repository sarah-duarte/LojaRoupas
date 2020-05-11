using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;

namespace LojaRoupas
{
    public partial class frmListaFornecedor : Form
    {
        public frmListaFornecedor()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            Fornecedor fornecedor = new Fornecedor();
            List<Fornecedor> lista = fornecedor.ListaFornecedor();
            foreach (Fornecedor f in lista)
            {
                //Console.WriteLine("{0}", f.getId().ToString());
                ListViewItem item = new ListViewItem(f.getId().ToString());
                item.SubItems.Add(f.getRazaosocial());
                item.SubItems.Add(f.getCnpj());
                item.SubItems.Add(f.getEndereco());
                item.SubItems.Add(f.getTelefone());
                lstListaFornecedor.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaFornecedor.Clear();
            lstListaFornecedor.View = View.Details;
            lstListaFornecedor.Columns.Add("ID", 48);
            lstListaFornecedor.Columns.Add("RAZÃO SOCIAL", 169);
            lstListaFornecedor.Columns.Add("CNPJ", 110);
            lstListaFornecedor.Columns.Add("ENDEREÇO", 187);
            lstListaFornecedor.Columns.Add("TELEFONE", 155);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmFornecedor telaFornecedor = new frmFornecedor();
            telaFornecedor.ShowDialog();
            MontaLista();
            AtualizaLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();           
        }

        private void frmListaFornecedor_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
    }
}
