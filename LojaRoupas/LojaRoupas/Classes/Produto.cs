using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class Produto
    {
        private int id;
        private string codigoBarras;
        private string descricao;
        private string corProduto;
        private string tamProduto;
        private Double precoCusto;
        private Double precoVenda;
        private int qtdEstProduto;
        MProduto conexao = new MProduto();

        public void setIdProduto(int id) { this.id = id; }
        public void setCodigoBarras(string codigoBarras) { this.codigoBarras = codigoBarras; }
        public void setDescProduto(string descricao) { this.descricao = descricao; }
        public void setCorProduto(string corProduto) { this.corProduto = corProduto; }
        public void setTamProduto(string tamProduto) { this.tamProduto = tamProduto; }
        public void setPrecoCusto(Double precoCusto) { this.precoCusto = precoCusto; }
        public void setPrecoVenda(Double precoVenda) { this.precoVenda = precoVenda; }
        public void setQtdEstProduto(int qtdEstProduto) { this.qtdEstProduto = qtdEstProduto; }

        public int getIdProduto(){ return this.id; }
        public string getCodigoBarras() { return this.codigoBarras; }
        public string getDescProduto(){ return this.descricao; }
        public string getCorProduto(){ return this.corProduto; }
        public string getTamProduto(){ return this.tamProduto; }        
        public Double getPrecoCusto(){ return this.precoCusto; }
        public Double getPrecoVenda(){ return this.precoVenda; }
        public int getQtdEstProduto(){ return this.qtdEstProduto; }

        public int NovoId() => conexao.GetNovoId();
        public void CadProduto(Produto produto) => conexao.InserirProduto(produto);
        public void EditarProduto(Produto produto) => conexao.EditarProduto(produto);
        public List<Produto> ListaProduto() => conexao.ListarProduto();
        public List<Produto> ListaProduto(String codigobarras, String descricao, String cor, String tamanho, Double precocusto, Double precovenda)
        {
            return conexao.ListarProduto(codigobarras, descricao, cor, tamanho, precocusto, precovenda);
        }
        public Produto GetProduto(String codigobarras) => conexao.getProduto(codigobarras);
        public Produto GetProduto(int id) => conexao.getProduto(id);
        public String GetDescProduto(int id) => conexao.getDescProduto(id);
        public void SaidaEstoqueProduto(int qtdvendida, int id) => conexao.SaidaEstoqueProduto(qtdvendida, id);
        public void EntradaEstoqueProduto(int qtdcomprada, int id) => conexao.EntradaEstoqueProduto(qtdcomprada, id);
    }
}