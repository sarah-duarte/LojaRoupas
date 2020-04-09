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

        public int NovoId()
        {
            MProduto conexao = new MProduto();
            return conexao.GetNovoId();
        }
        public void cadProduto(Produto produto)
        {
            MProduto conexao = new MProduto();
            conexao.InserirProduto(produto);
        }
        public List<Produto> ListaProduto()
        {
            MProduto conexao = new MProduto();
            return conexao.ListaProduto();
        }
        public Produto getProduto(String codigobarras)
        {
            MProduto conexao = new MProduto();
            return conexao.getProduto(codigobarras);
        }
    }
}