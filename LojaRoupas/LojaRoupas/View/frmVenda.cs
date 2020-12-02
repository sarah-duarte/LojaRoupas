﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using LojaRoupas.Classes;
using LojaRoupas.Controller;
namespace LojaRoupas
{
    public partial class frmVenda : Form
    {
        Venda venda = new Venda();
        CVenda cVenda = new CVenda();
        CItemVenda cItem = new CItemVenda();
        CCliente cCliente = new CCliente();
        COperador cOperador = new COperador();
        CProduto cProduto = new CProduto();
        List<Cliente> ListarClientes = new List<Cliente>();
        List<Operador> ListaOperador = new List<Operador>();
        List<ItemVenda> itensVenda = new List<ItemVenda>();
        public frmVenda()
        {
            InitializeComponent();
        }
        private void MontaLista()
        {
            lstListaItensVenda.Clear();
            lstListaItensVenda.View = View.Details;
            lstListaItensVenda.Columns.Add("CÓDIGO", 80);
            lstListaItensVenda.Columns.Add("DESCRIÇÃO", 253);
            lstListaItensVenda.Columns.Add("PREÇO", 70);
            lstListaItensVenda.Columns.Add("QTDE", 70);
            lstListaItensVenda.Columns.Add("TOTAL", 76);
        }
        private void AddItemLista(Produto prod)
        {
            ItemVenda itemV = new ItemVenda();
            itemV.setID(cItem.NovoId());
            itemV.setIdDocumento(int.Parse(lblID.Text));
            itemV.setIdProduto(prod.getIdProduto());
            itemV.setQtdItens(int.Parse(txtQtd.Text));
            itemV.SetPrcVenda(prod.getPrecoVenda());
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
            if (txtQtd.Text != String.Empty & int.Parse(txtQtd.Text) > 0 & txtCodBarras.Text != String.Empty)
            {
                Produto produto = new Produto();
                produto = cProduto.GetProduto(txtCodBarras.Text);
                if (produto.getIdProduto() > 0)
                {
                    if (produto.getQtdEstProduto() >= int.Parse(txtQtd.Text))
                    {
                        ListViewItem item = new ListViewItem(produto.getCodigoBarras());
                        item.SubItems.Add(produto.getDescProduto() + " " + produto.getCorProduto() + " " + produto.getTamProduto());
                        item.SubItems.Add(produto.getPrecoVenda().ToString());
                        item.SubItems.Add(txtQtd.Text);
                        item.SubItems.Add((produto.getPrecoVenda() * int.Parse(txtQtd.Text)).ToString());
                        lstListaItensVenda.Items.Add(item);

                        AddItemLista(produto);
                        lblTotal.Text = "R$ " + GetTotalProdutos().ToString();
                        lblQtdItens.Text = GetTotalQtdItens().ToString();

                        txtCodBarras.Text = "";
                        txtQtd.Text = "1";
                    }
                    else
                    {
                        MessageBox.Show("Quantidade solicitada acima da quantidade disponível! Quantidade em Estoque: "
                                        + produto.getQtdEstProduto().ToString(), "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Você deve adicionar uma quantidade acima de 0 e adicionar um codigo de barras valido!", "Validações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ListarClienteComboBox()
        {
            int i = 0;
            try
            {
                ListarClientes = cCliente.ListarCliente();
                foreach (Cliente c in ListarClientes)
                {
                    cmbCliente.Items.Insert(i, c.getNome());
                    i++;
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListarOperadorComboBox()
        {
            int i = 0;
            try 
            {
                ListaOperador = cOperador.ListarOperador();
                foreach (Operador c in ListaOperador)
                {
                    cmbOperador.Items.Insert(i, c.getNome());
                    i++;
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void frmVenda_Load(object sender, EventArgs e)
        {
            ListarClienteComboBox();
            ListarOperadorComboBox();
            lblID.Text = Convert.ToString(cVenda.NovoId());
            txtQtd.Text = "1";
            txtDesconto.Text = "0,00";
            MontaLista();
        }
        private void MontaVenda()
        {
            venda.setIdCliente(cCliente.GetIdCliente(cmbCliente.Text));
            venda.setIdOperador(cOperador.GetIDOperador(cmbOperador.Text));
            venda.setItensVenda(itensVenda);
            venda.setData(DateTime.Today.ToString("d"));
            venda.setQtdItens(GetTotalQtdItens());
            venda.setVlrTotal((GetTotalProdutos() - double.Parse(txtDesconto.Text)));
            venda.setDesconto(double.Parse(txtDesconto.Text));
        }
        private Boolean Validacoes()
        {
            Boolean retorno = true;
            if (cmbOperador.SelectedIndex == -1)
            {
                MessageBox.Show("Um Operador deve ser escolhido!", "Validações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            if (itensVenda.Count == 0)
            {
                MessageBox.Show("Produto deve ser escolhido!", "Validações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            return retorno;
        }
        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (Validacoes())
            {
                MontaVenda();
                try
                {
                    cVenda.InserirVenda(venda);
                    MessageBox.Show("Venda Realizada com Sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (IOException erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();
        private void btnDesconto_Click(object sender, EventArgs e)
        {
            if (Validacoes())
            {
                pnlDesconto.Visible = true;
                txtDesconto.Text = "0,00";
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDesconto.Text != string.Empty & double.Parse(txtDesconto.Text) >= 0)
            {
                if (rdbValor.Checked)
                {
                    txtDesconto.Text = txtDesconto.Text;
                }
                else if (rdbPerc.Checked)
                {
                    rdbValor.Checked = true;
                    txtDesconto.Text = (double.Parse(txtDesconto.Text) / 100 * GetTotalProdutos()).ToString();
                }
                else
                {
                    rdbValor.Checked = true;
                    txtDesconto.Text = "0,00";
                }          
            } 
            else txtDesconto.Text = "0,00";

            if (double.Parse(txtDesconto.Text) <= GetTotalProdutos())
            {
                txtDesconto.Text = txtDesconto.Text;
                lblTotal.Text = "R$ " + (GetTotalProdutos() - double.Parse(txtDesconto.Text)).ToString();
            }
            else
            {
                txtDesconto.Text = "0,00";
                MessageBox.Show("Desconto acima do valor total!", "Desconto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lblDesconto.Text = "R$ " + txtDesconto.Text;
            pnlDesconto.Visible = false;
        }
        private void btnPesqProduto_Click(object sender, EventArgs e)
        {
            txtCodBarras.Text = cProduto.TelaPesquisaProduto();
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}