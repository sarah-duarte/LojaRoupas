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
    public partial class frmListaProdutos : Form
    {
        public frmListaProdutos()
        {
            InitializeComponent();
        }

        private void frmListaProdutos_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            dgvListaProduto.DataSource = produto.ListaProduto();
            dgvListaProduto.DataBindingComplete += DgvListaProduto_DataBindingComplete;
        }

        private void DgvListaProduto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}