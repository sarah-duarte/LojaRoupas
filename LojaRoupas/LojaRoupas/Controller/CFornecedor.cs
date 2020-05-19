using System;
using System.Collections.Generic;
using LojaRoupas.Model;
using LojaRoupas.Classes;
using System.Windows.Forms;
using System.IO;

namespace LojaRoupas.Controller
{
    class CFornecedor
    {
        MFornecedor conexao = new MFornecedor();
        MCompra compra = new MCompra();

        public int NovoId() => conexao.GetNovoId();
        public void InserirFornecedor(Fornecedor fornecedor) => conexao.InserirFornecedor(fornecedor);
        public void EditarFornecedor(Fornecedor Fornecedor) => conexao.EditarFornecedor(Fornecedor);
        public void ExcluirFornecedor(int idFornecedor)
        {
            if (compra.QtdCompraFornecedor(idFornecedor) == 0)
            {
                try
                {
                    conexao.ExcluirFornecedor(idFornecedor);
                    MessageBox.Show("Fornecedor Excluído com Sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fornecedor possui compras e não pode ser excluído", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public List<Fornecedor> ListarFornecedor() => conexao.ListarFornecedor();
        public Fornecedor GetFornecedor(int id) => conexao.getFornecedor(id);
        public String GetNomeFornecedor(int id) => conexao.getNomeFornecedor(id);
        public int GetIdFornecedor(string NomeFornecedor) => conexao.GetIdFornecedor(NomeFornecedor);
        public void SalvarFornecedor(Fornecedor Fornecedor)
        {
            if (GetFornecedor(Fornecedor.getId()).getId() == 0)
            {
                InserirFornecedor(Fornecedor);
            }
            else
            {
                EditarFornecedor(Fornecedor);
            }
        }
        public void TelaFornecedor(int idFornecedor)
        {
            frmFornecedor telaFornecedor = new frmFornecedor();
            telaFornecedor.Fornecedor = GetFornecedor(idFornecedor);
            telaFornecedor.ShowDialog();
        }
        public void TelaListaFornecedor()
        {
            frmListaFornecedor telaListaFornecedor = new frmListaFornecedor();
            telaListaFornecedor.ShowDialog();
        }
    }
}