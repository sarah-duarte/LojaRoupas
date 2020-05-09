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
using System.IO;

namespace LojaRoupas
{
    public partial class frmUsuarios : Form
    {
        Usuario usuario = new Usuario();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            lblID.Text = Convert.ToString(usuario.NovoId());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            usuario.setId(int.Parse(lblID.Text));
            usuario.setCpf(txtCPF.Text);
            usuario.setNome(txtNome.Text);
            usuario.setLogin(txtLogin.Text);
            usuario.setSenha(txtSenha.Text);
            usuario.setEmail(txtEmail.Text);
            usuario.setEndereco(txtEndereco.Text);
            usuario.setNascimento(txtNascimento.Text);
            usuario.setTelefone(txtTelefone.Text);
            try
            {
                usuario.cadUsuario(usuario);
                MessageBox.Show("Usuario Cadastrado com Sucesso!", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
