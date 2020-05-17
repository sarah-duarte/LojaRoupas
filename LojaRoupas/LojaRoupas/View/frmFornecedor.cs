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
        CFornecedor f = new CFornecedor();
        private Fornecedor fornecedor = new Fornecedor();
        internal Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }        
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
            Fornecedor.setId(int.Parse(lblID.Text));
            Fornecedor.setCnpj(txtCnpj.Text);
            Fornecedor.setRazaosocial(txtRazaoSocial.Text);
            Fornecedor.setEndereco(txtEndereco.Text);
            Fornecedor.setTelefone(txtTelefone.Text);
            try
            {
                f.SalvarFornecedor(Fornecedor);
                MessageBox.Show("Fornecedor Salvo com Sucesso!", "Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            if (Fornecedor.getId() != 0)
            {
                lblID.Text = Fornecedor.getId().ToString();
                txtCnpj.Text = Fornecedor.getCnpj();
                txtRazaoSocial.Text = Fornecedor.getRazaosocial();
                txtEndereco.Text = Fornecedor.getEndereco();
                txtTelefone.Text = Fornecedor.getTelefone();
            }
            else
            {
                lblID.Text = Convert.ToString(f.NovoId());
            }
        }
    }
}