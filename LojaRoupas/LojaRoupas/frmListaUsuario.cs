﻿using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaRoupas.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;


namespace LojaRoupas
{
    public partial class frmListaUsuario : Form
    {
        public frmListaUsuario()
        {
            InitializeComponent();
        }
        private void AtualizaLista()
        {
            Usuario usuario = new Usuario();
            List<Usuario> lista = usuario.ListaUsuario();
            foreach (Usuario o in lista)
            {
                Console.WriteLine("{0}", o.getId().ToString());
                ListViewItem item = new ListViewItem(o.getId().ToString());
                item.SubItems.Add(o.getNome());
                item.SubItems.Add(o.getCpf());
                item.SubItems.Add(o.getEmail());
                item.SubItems.Add(o.getTelefone());
                item.SubItems.Add(o.getNascimento());
                item.SubItems.Add(o.getLogin());
                item.SubItems.Add(o.getEndereco());
                lstListaUsuario.Items.Add(item);
            }
        }
        private void MontaLista()
        {
            lstListaUsuario.Clear();
            lstListaUsuario.View = View.Details;
            lstListaUsuario.Columns.Add("ID", 28);
            lstListaUsuario.Columns.Add("NOME", 84);
            lstListaUsuario.Columns.Add("CPF", 102);
            lstListaUsuario.Columns.Add("EMAIL", 131);
            lstListaUsuario.Columns.Add("TELEFONE", 79);
            lstListaUsuario.Columns.Add("NASC.", 71);
            lstListaUsuario.Columns.Add("LOGIN", 60);
            lstListaUsuario.Columns.Add("ENDEREÇO", 154);

        }
        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            MontaLista();
            AtualizaLista();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmUsuarios telaUsuarios = new frmUsuarios();
            telaUsuarios.ShowDialog();
            MontaLista();
            AtualizaLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        
    }
}