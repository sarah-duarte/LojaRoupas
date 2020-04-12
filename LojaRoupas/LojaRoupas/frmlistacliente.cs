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
    public partial class frmlistaCliente : Form
    {
        public frmlistaCliente()
        {
            InitializeComponent();
        }

        private void AtualizaLista()
        {
            Cliente cliente = new Cliente();
            List<Cliente> lista = cliente.ListaCliente();
            foreach (Cliente c in lista)
            {
                Console.WriteLine("{0}", c.getId().ToString());
                ListViewItem item = new ListViewItem(c.getId().ToString());
                item.SubItems.Add(c.getNome());
                item.SubItems.Add(c.getCpf());
                item.SubItems.Add(c.getEmail());
                item.SubItems.Add(c.getTelefone());
                item.SubItems.Add(c.getNascimento());
                item.SubItems.Add(c.getEndereco());
                lstListaCliente.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaCliente.Clear();
            lstListaCliente.View = View.Details;
            lstListaCliente.Columns.Add("ID", 42);
            lstListaCliente.Columns.Add("Nome", 148);
            lstListaCliente.Columns.Add("CPF", 63);
            lstListaCliente.Columns.Add("EMAIL", 126);
            lstListaCliente.Columns.Add("TELEFONE", 119);
            lstListaCliente.Columns.Add("NASCIMENTO", 117);
            lstListaCliente.Columns.Add("ENDEREÇO", 156);
            lstListaCliente.Columns.Add("COMPRAS REALIZADAS", 373);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCliente telaCliente = new frmCliente();
            telaCliente.ShowDialog();
            MontaLista();
            AtualizaLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmlistaCliente_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
    }
}
