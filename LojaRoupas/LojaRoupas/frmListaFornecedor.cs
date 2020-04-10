using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine("{0}", f.getId().ToString());
                ListViewItem item = new ListViewItem(f.getId().ToString());
                item.SubItems.Add(f.getCnpj());
                item.SubItems.Add(f.getRazaosocial());
                item.SubItems.Add(f.getEndereco());
                item.SubItems.Add(f.getTelefone());
                listView1.Items.Add(item);
            }
        }

        private void MontaLista()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 103);
            listView1.Columns.Add("Razão Social", 169);
            listView1.Columns.Add("Endereço", 187);
            listView1.Columns.Add("Telefone", 179);
        }
        private void frmListaFornecedor_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            this.Close();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
