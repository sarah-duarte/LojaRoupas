using System;
using System.Windows.Forms;
using LojaRoupas.Classes;
using System.IO;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmUsuarios : Form
    {
        CUsuario u = new CUsuario();
        private Usuario usuario = new Usuario();
        internal Usuario Usuario { get => usuario; set => usuario = value; }
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            if (Usuario.getId() != 0)
            {
                lblID.Text = Usuario.getId().ToString();
                txtCPF.Text = Usuario.getCpf();
                txtNome.Text = Usuario.getNome();
                txtEmail.Text = Usuario.getEmail();
                txtEndereco.Text = Usuario.getEndereco();
                txtNascimento.Text = Usuario.getNascimento();
                txtTelefone.Text = Usuario.getTelefone();
                txtLogin.Text = Usuario.getLogin();
                txtSenha.Text = Usuario.getSenha();
            }
            else
            {
                lblID.Text = Convert.ToString(u.NovoId());
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario.setId(int.Parse(lblID.Text));
            Usuario.setCpf(txtCPF.Text);
            Usuario.setNome(txtNome.Text);
            Usuario.setLogin(txtLogin.Text);
            Usuario.setSenha(txtSenha.Text);
            Usuario.setEmail(txtEmail.Text);
            Usuario.setEndereco(txtEndereco.Text);
            Usuario.setNascimento(txtNascimento.Text);
            Usuario.setTelefone(txtTelefone.Text);
            try
            {
                u.SalvarUsuario(Usuario);
                MessageBox.Show("Usuario Salvo com Sucesso!", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }    
}