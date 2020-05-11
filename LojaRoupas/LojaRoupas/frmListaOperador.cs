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
                //Console.WriteLine("{0}", o.getId().ToString());
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
            frmOperador telaoperador = new frmOperador();
            telaoperador.ShowDialog();
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
    }
}
