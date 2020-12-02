using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas
{
    public partial class frmCompra : Form
    {
        Compra Compra = new Compra();
        CCompra c = new CCompra();
        CItemCompra ic = new CItemCompra();
        CFornecedor Fornecedor = new CFornecedor();
        CProduto cProduto = new CProduto();
        List<Fornecedor> ListaFornecedor = new List<Fornecedor>();
        List<ItemCompra> itensCompra = new List<ItemCompra>();
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
            itemV.setID(ic.NovoId());
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
            int i = 0;
            try
            {
                ListaFornecedor = Fornecedor.ListarFornecedor();
                foreach (Fornecedor c in ListaFornecedor)
                {
                    cmbFornecedor.Items.Insert(i, c.getRazaosocial());
                    i++;
                }
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MontaCompra()
        {
            Compra.setIdFornecedor(Fornecedor.GetIdFornecedor(cmbFornecedor.Text));
            Compra.setItensCompra(itensCompra);
            Compra.setData(DateTime.Today.ToString("d"));
            Compra.setQtdItens(GetTotalQtdItens());
            Compra.setVlrTotal((GetTotalProdutos() - double.Parse(txtDesconto.Text)));
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
            lblID.Text = Convert.ToString(c.NovoId());
            txtQtd.Text = "1";
            txtDesconto.Text = "0,00";
            MontaLista();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtQtd.Text != String.Empty & int.Parse(txtQtd.Text) > 0 & txtCodBarras.Text != String.Empty)
            {
                Produto produto = new Produto();
                produto = cProduto.GetProduto(txtCodBarras.Text);
                if (produto.getIdProduto() > 0)
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
                    c.InserirCompra(Compra);
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

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}