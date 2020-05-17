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
    public partial class frmOperador : Form
    {
        COperador o = new COperador();
        private Operador operador = new Operador();
        internal Operador Operador { get => operador; set => operador = value; }
        public frmOperador()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Operador.setId(int.Parse(lblID.Text));
            Operador.setCpf(txtCPF.Text);
            Operador.setNome(txtNome.Text);
            Operador.setEmail(txtEmail.Text);
            Operador.setEndereco(txtEndereco.Text);
            Operador.setNascimento(txtNascimento.Text);
            Operador.setTelefone(txtTelefone.Text);
            Operador.setTurno(cmbTurno.Text);
            try
            {
                o.SalvarOperador(Operador);
                MessageBox.Show("Operador Cadastrado com Sucesso!", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void frmOperador_Load(object sender, EventArgs e)
        {
            if (Operador.getId() != 0)
            {
                lblID.Text = Operador.getId().ToString();
                txtCPF.Text = Operador.getCpf();
                txtNome.Text = Operador.getNome();
                txtEmail.Text = Operador.getEmail();
                txtEndereco.Text = Operador.getEndereco();
                txtNascimento.Text = Operador.getNascimento();
                txtTelefone.Text = Operador.getTelefone();
                cmbTurno.Text = Operador.getTurno();
            }
            else
            {
                lblID.Text = Convert.ToString(o.NovoId());
            }
        }
    }
}
