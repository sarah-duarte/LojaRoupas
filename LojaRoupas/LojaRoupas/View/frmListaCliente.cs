using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmListaCliente : Form
    {
        CCliente c = new CCliente();
        public frmListaCliente()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            List<Cliente> lista = c.ListarCliente();
            foreach (Cliente c in lista)
            {
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
            lstListaCliente.Columns.Add("ID", 26);
            lstListaCliente.Columns.Add("NOME", 158);
            lstListaCliente.Columns.Add("CPF", 126);
            lstListaCliente.Columns.Add("EMAIL", 154);
            lstListaCliente.Columns.Add("TELEFONE", 90);
            lstListaCliente.Columns.Add("NASCIMENTO", 85);
            lstListaCliente.Columns.Add("ENDEREÇO", 213);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {            
            c.TelaCliente();
            MontaLista();
            AtualizaLista();
        }
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
        private void frmListaCliente_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
    }
}
