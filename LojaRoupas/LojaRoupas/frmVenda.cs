﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaRoupas.Classes;

namespace LojaRoupas
{
    public partial class frmVenda : Form
    {
        List<ItemVenda> itensVenda = new List<ItemVenda>();
        Venda venda = new Venda();
        List<Cliente> ListaClientes = new List<Cliente>();
        Cliente cliente = new Cliente();
        List<Operador> ListaOperador = new List<Operador>();
        Operador Operador = new Operador();
        public frmVenda()
        {
            InitializeComponent();
        }
        private void MontaLista()
        {
            lstListaItensVenda.Clear();
            lstListaItensVenda.View = View.Details;
            lstListaItensVenda.Columns.Add("CÓDIGO", 66);
            lstListaItensVenda.Columns.Add("DESCRIÇÃO", 265);
            lstListaItensVenda.Columns.Add("PREÇO", 70);
            lstListaItensVenda.Columns.Add("QTDE", 70);
            lstListaItensVenda.Columns.Add("TOTAL", 76);
        }
        private void AddItemLista(Produto prod)
        {
            ItemVenda itemV = new ItemVenda();
            itemV.setID(itemV.NovoId());
            itemV.setIdDocumento(int.Parse(lblID.Text));
            itemV.setIdProduto(prod.getIdProduto());
            itemV.setQtdItens(int.Parse(txtQtd.Text));
            itemV.setPrcVenda(prod.getPrecoVenda());
            itemV.setTotalPreco(prod.getPrecoVenda() * int.Parse(txtQtd.Text));
            itensVenda.Add(itemV);
        }
        private Double GetTotalProdutos()
        {
            Double TotalProduto = 0;
            foreach (ItemVenda itV in itensVenda)
            {
                Console.WriteLine("{0}", itV.getId().ToString());
                TotalProduto += itV.getTotalPreco();
            }
            return TotalProduto;
        }
        private int GetTotalQtdItens()
        {
            int TotalQtdItens = 0;
            foreach (ItemVenda itV in itensVenda)
            {
                Console.WriteLine("{0}", itV.getId().ToString());
                TotalQtdItens += itV.getQtdItens();
            }
            return TotalQtdItens;
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto = produto.getProduto(txtCodBarras.Text);
            Console.WriteLine("{0}", produto.getIdProduto().ToString());
            ListViewItem item = new ListViewItem(produto.getCodigoBarras());
            item.SubItems.Add(produto.getDescProduto() +" "+ produto.getCorProduto() +" "+ produto.getTamProduto());
            item.SubItems.Add(produto.getPrecoVenda().ToString());
            item.SubItems.Add(txtQtd.Text);
            item.SubItems.Add((produto.getPrecoVenda()* int.Parse(txtQtd.Text)).ToString());
            lstListaItensVenda.Items.Add(item);

            AddItemLista(produto);
            lblTotal.Text = "R$ " + GetTotalProdutos().ToString();
            lblQtdItens.Text = GetTotalQtdItens().ToString();
        }
        private void ListarClienteComboBox()
        {
            ListaClientes = cliente.ListaCliente();
            foreach (Cliente c in ListaClientes)
            {
                Console.WriteLine("{0}", c.getId().ToString());
                cmbCliente.Items.Insert(c.getId() - 1, c.getNome());
            }
        }
        private void ListarOperadorComboBox()
        {
            ListaOperador = Operador.ListaOperador();
            foreach (Operador c in ListaOperador)
            {
                Console.WriteLine("{0}", c.getId().ToString());
                cmbOperador.Items.Insert(c.getId() - 1, c.getNome());
            }
        }
        private void frmVenda_Load(object sender, EventArgs e)
        {
            ListarClienteComboBox();
            ListarOperadorComboBox();
            lblID.Text = Convert.ToString(venda.NovoId());
            MontaLista();
        }
        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente selecionado " + (cmbCliente.SelectedItem).ToString() + " id " + (cmbCliente.SelectedIndex + 1).ToString());
            MessageBox.Show("Operador selecionado " + (cmbOperador.SelectedItem).ToString() + " id " + (cmbOperador.SelectedIndex + 1).ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}