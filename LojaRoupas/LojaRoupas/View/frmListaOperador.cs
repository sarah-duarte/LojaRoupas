using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmListaOperador : Form
    {
        COperador o = new COperador();
        public frmListaOperador()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            List<Operador> lista = o.ListarOperador();
            foreach (Operador o in lista)
            {
                ListViewItem item = new ListViewItem(o.getId().ToString());
                item.SubItems.Add(o.getNome());
                item.SubItems.Add(o.getCpf());
                item.SubItems.Add(o.getEmail());
                item.SubItems.Add(o.getTelefone());
                item.SubItems.Add(o.getNascimento());
                item.SubItems.Add(o.getEndereco());
                item.SubItems.Add(o.getTurno());
                lstListaOperador.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaOperador.Clear();
            lstListaOperador.View = View.Details;
            lstListaOperador.Columns.Add("ID", 28);
            lstListaOperador.Columns.Add("NOME", 84);
            lstListaOperador.Columns.Add("CPF", 102);
            lstListaOperador.Columns.Add("EMAIL", 131);
            lstListaOperador.Columns.Add("TELEFONE", 79);
            lstListaOperador.Columns.Add("NASCIMENTO", 71);
            lstListaOperador.Columns.Add("ENDEREÇO", 154);
            lstListaOperador.Columns.Add("TURNO", 99);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            o.TelaOperador(0);
            MontaLista();
            AtualizaLista();
        }
        private void frmListaOperador_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Selecionado =
                this.lstListaOperador.SelectedItems;

            foreach (ListViewItem item in Selecionado)
            {
                o.TelaOperador(int.Parse(item.SubItems[0].Text));
            }
            MontaLista();
            AtualizaLista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Selecionado =
                this.lstListaOperador.SelectedItems;

            foreach (ListViewItem item in Selecionado)
            {
                o.ExcluirOperador(int.Parse(item.SubItems[0].Text));
            }
            MontaLista();
            AtualizaLista();
        }

        private void lstListaOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
