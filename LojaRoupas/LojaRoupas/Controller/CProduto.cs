using LojaRoupas.Classes;
using LojaRoupas.Model;
using System;
using System.Collections.Generic;

namespace LojaRoupas.Controller
{
    class CProduto
    {
        MProduto conexao = new MProduto();

        public int NovoId() => conexao.GetNovoId();
        public void InserirProduto(Produto produto) => conexao.InserirProduto(produto);
        public void EditarProduto(Produto produto) => conexao.EditarProduto(produto);
        public List<Produto> ListarProduto() => conexao.ListarProduto();
        public List<Produto> ListarProduto(String codigobarras, String descricao, String cor, String tamanho, Double precocusto, Double precovenda)
        {
            return conexao.ListarProduto(codigobarras, descricao, cor, tamanho, precocusto, precovenda);
        }
        public Produto GetProduto(String codigobarras) => conexao.getProduto(codigobarras);
        public Produto GetProduto(int id) => conexao.getProduto(id);
        public String GetDescProduto(int id) => conexao.getDescProduto(id);
        public void SaidaEstoqueProduto(int qtdvendida, int id) => conexao.SaidaEstoqueProduto(qtdvendida, id);
        public void EntradaEstoqueProduto(int qtdcomprada, int id) => conexao.EntradaEstoqueProduto(qtdcomprada, id);
        public void SalvarProduto(Produto Produto)
        {
            if (GetProduto(Produto.getIdProduto()).getIdProduto() == 0)
            {
                InserirProduto(Produto);
            }
            else
            {
                EditarProduto(Produto);
            }
        }
        public void TelaProduto(int idProduto)
        {
            frmProduto telaProduto = new frmProduto();
            telaProduto.Produto = GetProduto(idProduto);
            telaProduto.ShowDialog();
        }
        public void TelaListaProduto()
        {
            frmListaProdutos telaListaProduto = new frmListaProdutos();
            telaListaProduto.ShowDialog();
        }
        public string TelaPesquisaProduto()
        {
            frmPesquisaProduto telaPesqProduto = new frmPesquisaProduto();
            telaPesqProduto.ShowDialog();
            return telaPesqProduto.Produto.getCodigoBarras();
        }
    }
}