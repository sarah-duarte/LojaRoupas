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
using LojaRoupas.Controller;
using System.IO;


namespace LojaRoupas
{
    public partial class frmCliente : Form
    {
        CCliente ccliente = new CCliente();
        private Cliente cliente = new Cliente();
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente.setId(int.Parse(lblID.Text));
            Cliente.setCpf(txtCPF.Text);
            Cliente.setNome(txtNome.Text);
            Cliente.setEmail(txtEmail.Text);
            Cliente.setEndereco(txtEndereco.Text);
            Cliente.setNascimento(txtNascimento.Text);
            Cliente.setTelefone(txtTelefone.Text);
            try
            {
                ccliente.SalvarCliente(Cliente);
                MessageBox.Show("Cliente Salvo com Sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (Cliente.getId() != 0)
            {
                lblID.Text = Cliente.getId().ToString();
                txtCPF.Text = Cliente.getCpf();
                txtNome.Text = Cliente.getNome();
                txtEmail.Text = Cliente.getEmail();
                txtEndereco.Text = Cliente.getEndereco();
                txtNascimento.Text = Cliente.getNascimento();
                txtTelefone.Text = Cliente.getTelefone();
            }
            else
            {
                lblID.Text = Convert.ToString(ccliente.NovoId());
            }            
        }
    }
}
