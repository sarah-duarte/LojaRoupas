using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{   
    public partial class frmFornecedor : Form
    {
        Fornecedor fornecedor = new Fornecedor();
        CFornecedor f = new CFornecedor();
        public frmFornecedor()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            fornecedor.setId(int.Parse(lblID.Text));
            fornecedor.setCnpj(txtCnpj.Text);
            fornecedor.setRazaosocial(txtRazaoSocial.Text);
            fornecedor.setEndereco(txtEndereco.Text);
            fornecedor.setTelefone(txtTelefone.Text);
            try
            {
                f.InserirFornecedor(fornecedor);
                MessageBox.Show("Fornecedor Cadastrado com Sucesso!", "Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            lblID.Text = Convert.ToString(f.NovoId());
        }
    }
}