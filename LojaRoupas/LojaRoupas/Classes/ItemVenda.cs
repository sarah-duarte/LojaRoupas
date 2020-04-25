using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class ItemVenda : ItemDocumento
    {
        private Double prcVenda;
        MItemVenda conexao = new MItemVenda();

        public Double GetPrcVenda(){ return this.prcVenda; }
        public void SetPrcVenda(Double prcVenda){ this.prcVenda = prcVenda; }

        public int NovoId() => conexao.GetNovoId();
        public void CadItemVenda(ItemVenda itemVenda)
        {            
            conexao.InserirItemVenda(itemVenda);
            Produto produto = new Produto();
            produto.SaidaEstoqueProduto(itemVenda.getQtdItens(), itemVenda.getIdProduto());
        }
        public List<ItemVenda> ListaItemVenda(int idVenda) => conexao.ListaItemVenda(idVenda);
    }
}