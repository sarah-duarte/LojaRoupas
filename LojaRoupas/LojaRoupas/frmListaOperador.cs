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
    public partial class frmListaOperador : Form
    {
        public frmListaOperador()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            Operador operador = new Operador();
            List<Operador> lista = operador.ListaOperador();
            foreach (Operador o in lista)
            {
                Console.WriteLine("{0}", o.getId().ToString());
                ListViewItem item = new ListViewItem(o.getId().ToString());
                item.SubItems.Add(o.getCpf());
                item.SubItems.Add(o.getNome());
                item.SubItems.Add(o.getEndereco());
                item.SubItems.Add(o.getTelefone());
                item.SubItems.Add(o.getTurno());
                item.SubItems.Add(o.getNascimento());
                item.SubItems.Add(o.getEmail());
                lstListaOperador.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaOperador.Clear();
            lstListaOperador.View = View.Details;
            lstListaOperador.Columns.Add("ID", 60);
            lstListaOperador.Columns.Add("Nome", 60);
            lstListaOperador.Columns.Add("Cpf", 60);
            lstListaOperador.Columns.Add("Email", 60);
            lstListaOperador.Columns.Add("Telefone", 60);
            lstListaOperador.Columns.Add("Nascimento", 60);
            lstListaOperador.Columns.Add("Endereço", 60);
            lstListaOperador.Columns.Add("Turno", 60);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmOperador telaoperador = new frmOperador();
            telaoperador.ShowDialog();
        }

        private void lstListaOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmListaOperador_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
    }
}
