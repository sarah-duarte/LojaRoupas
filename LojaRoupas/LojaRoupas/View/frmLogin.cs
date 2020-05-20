using LojaRoupas.Controller;
using System;
using System.Windows.Forms;

namespace LojaRoupas
{
    public partial class frmLogin : Form
    {
        CUsuario u = new CUsuario();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != String.Empty & txtLogin.Text != String.Empty)
            {
                if (u.GetSenhaUsuario(txtLogin.Text) == txtSenha.Text)
                {
                    frmPrincipal telaPrincipal = new frmPrincipal();
                    telaPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login ou Senha incorretos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Login e Senha devem estar preenchido", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llblNovoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            u.TelaUsuario(0);
        }
    }
}