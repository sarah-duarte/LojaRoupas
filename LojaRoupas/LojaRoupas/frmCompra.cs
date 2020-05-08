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

namespace LojaRoupas
{
    public partial class frmCompra : Form
    {
        List<ItemCompra> itensCompra = new List<ItemCompra>();
        Compra Compra = new Compra();
        List<Fornecedor> ListaFornecedor = new List<Fornecedor>();
        Fornecedor Fornecedor = new Fornecedor();
        public frmCompra()
        {
            InitializeComponent();
        }
        private void MontaLista()
        {
            lstListaItensCompra.Clear();
            lstListaItensCompra.View = View.Details;
            lstListaItensCompra.Columns.Add("CÓDIGO", 80);
            lstListaItensCompra.Columns.Add("DESCRIÇÃO", 253);
            lstListaItensCompra.Columns.Add("PREÇO", 70);
            lstListaItensCompra.Columns.Add("QTDE", 70);
            lstListaItensCompra.Columns.Add("TOTAL", 76);
        }
        private void AddItemLista(Produto prod)
        {
            ItemCompra itemV = new ItemCompra();
            itemV.setID(itemV.NovoId());
            itemV.setIdDocumento(int.Parse(lblID.Text));
            itemV.setIdProduto(prod.getIdProduto());
            itemV.setQtdItens(int.Parse(txtQtd.Text));
            itemV.setPrcCusto(prod.getPrecoCusto());
            itemV.setTotalPreco(prod.getPrecoCusto() * int.Parse(txtQtd.Text));
            itensCompra.Add(itemV);
        }
        private Double GetTotalProdutos()
        {
            Double TotalProduto = 0;
            foreach (ItemCompra itV in itensCompra)
            {
                Console.WriteLine("{0}", itV.getId().ToString());
                TotalProduto += itV.getTotalPreco();
            }
            return TotalProduto;
        }
        private int GetTotalQtdItens()
        {
            int TotalQtdItens = 0;
            foreach (ItemCompra itV in itensCompra)
            {
                Console.WriteLine("{0}", itV.getId().ToString());
                TotalQtdItens += itV.getQtdItens();
            }
            return TotalQtdItens;
        }
        private void ListarFornecedorComboBox()
        {
            try
            {
                ListaFornecedor = Fornecedor.ListaFornecedor();
                foreach (Fornecedor c in ListaFornecedor)
                {
                    Console.WriteLine("{0}", c.getId().ToString());
                    cmbFornecedor.Items.Insert(c.getId() - 1, c.getRazaosocial());
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MontaCompra()
        {
            Compra.setIdFornecedor(cmbFornecedor.SelectedIndex + 1);
            Compra.setItensCompra(itensCompra);
            Compra.setData(DateTime.Today.ToString("d"));
            Compra.setQtdItens(GetTotalQtdItens());
            Compra.setVlrTotal(GetTotalProdutos());
            Compra.setDesconto(double.Parse(txtDesconto.Text));
        }
        private Boolean Validacoes()
        {
            Boolean retorno = true;
            if (cmbFornecedor.SelectedIndex == -1)
            {
                MessageBox.Show("Um Fornecedor deve ser escolhido!", "Validações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            if (itensCompra.Count == 0)
            {
                MessageBox.Show("Produto deve ser escolhido!", "Validações", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }
            return retorno;
        }
        private void frmCompra_Load(object sender, EventArgs e)
        {
            ListarFornecedorComboBox();
            lblID.Text = Convert.ToString(Compra.NovoId());
            txtQtd.Text = "1";
            txtDesconto.Text = "0.00";
            MontaLista();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtQtd.Text != String.Empty & int.Parse(txtQtd.Text) > 0 & txtCodBarras.Text != String.Empty)
            {
                Produto produto = new Produto();
                produto = produto.GetProduto(txtCodBarras.Text);
                if (produto.getIdProduto() > 0)
                {
                    if (produto.getQtdEstProduto() >= int.Parse(txtQtd.Text))
                    {

                        Console.WriteLine("{0}", produto.getIdProduto().ToString());
                        ListViewItem item = new ListViewItem(produto.getCodigoBarras());
                        item.SubItems.Add(produto.getDescProduto() + " " + produto.getCorProduto() + " " + produto.getTamProduto());
                        item.SubItems.Add(produto.getPrecoCusto().ToString());
                        item.SubItems.Add(txtQtd.Text);
                        item.SubItems.Add((produto.getPrecoCusto() * int.Parse(txtQtd.Text)).ToString());
                        lstListaItensCompra.Items.Add(item);

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
        private void btnCancelar_Click(object sender, EventArgs e) => Close();
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (Validacoes())
            {
                MontaCompra();
                try
                {
                    Compra.CadCompra(Compra);
                    MessageBox.Show("Compra Realizada com Sucesso!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (IOException erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDesconto_Click(object sender, EventArgs e)
        {
            if (Validacoes())
            {
                pnlDesconto.Visible = true;
                txtDesconto.Text = "0.00";
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
                lblDesconto.Text = "R$ " + txtDesconto.Text;
            }
            else txtDesconto.Text = "0,00";

            pnlDesconto.Visible = false;
        }

        private void btnPesqProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto telaPesqProduto = new frmPesquisaProduto();
            telaPesqProduto.ShowDialog();
        }
    }
}
