using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Produto
    {
        private int id;
        private string codigoBarras;
        private string descricao;
        private string corProduto;
        private string tamProduto;
        private float precoCusto;
        private float precoVenda;
        private int qtdEstProduto;

        public void setIdProduto(int id) { this.id = id; }
        public void setCodigoBarras(string codigoBarras) { this.codigoBarras = codigoBarras; }
        public void setDescProduto(string descricao) { this.descricao = descricao; }
        public void setCorProduto(string corProduto) { this.corProduto = corProduto; }
        public void setTamProduto(string tamProduto) { this.tamProduto = tamProduto; }
        public void setPrecoCusto(float precoCusto) { this.precoCusto = precoCusto; }
        public void setPrecoVenda(float precoVenda) { this.precoVenda = precoVenda; }
        public void setQtdEstProduto(int qtdEstProduto) { this.qtdEstProduto = qtdEstProduto; }

        public int getId(){ return this.id; }
        public string getCodigoBarras() { return this.codigoBarras; }
        public string getDescProduto(){ return this.descricao; }
        public string getCorProduto(){ return this.corProduto; }
        public string getTamProduto(){ return this.tamProduto; }        
        public float getPrecoCusto(){ return this.precoCusto; }
        public float getPrecoVenda(){ return this.precoVenda; }
        public int getQtdEstProduto(){ return this.qtdEstProduto; }
    }
}