using System;
using System.Windows.Forms;
using LojaRoupas.Classes;
using System.Collections.Generic;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmListaUsuario : Form
    {
        CUsuario u = new CUsuario();
        public frmListaUsuario()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            List<Usuario> lista = u.ListarUsuario();
            foreach (Usuario o in lista)
            {
                ListViewItem item = new ListViewItem(o.getId().ToString());
                item.SubItems.Add(o.getNome());
                item.SubItems.Add(o.getCpf());
                item.SubItems.Add(o.getEmail());
                item.SubItems.Add(o.getTelefone());
                item.SubItems.Add(o.getNascimento());
                item.SubItems.Add(o.getLogin());
                item.SubItems.Add(o.getEndereco());
                lstListaUsuario.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaUsuario.Clear();
            lstListaUsuario.View = View.Details;
            lstListaUsuario.Columns.Add("ID", 28);
            lstListaUsuario.Columns.Add("NOME", 84);
            lstListaUsuario.Columns.Add("CPF", 102);
            lstListaUsuario.Columns.Add("EMAIL", 131);
            lstListaUsuario.Columns.Add("TELEFONE", 79);
            lstListaUsuario.Columns.Add("NASC.", 71);
            lstListaUsuario.Columns.Add("LOGIN", 60);
            lstListaUsuario.Columns.Add("ENDEREÇO", 154);

        }
        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            u.TelaUsuario(0);
            MontaLista();
            AtualizaLista();
        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Selecionado =
                this.lstListaUsuario.SelectedItems;

            foreach (ListViewItem item in Selecionado)
            {
                u.TelaUsuario(int.Parse(item.SubItems[0].Text));
            }
            MontaLista();
            AtualizaLista();
        }
    }
}
