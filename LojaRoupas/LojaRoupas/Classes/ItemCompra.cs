using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class ItemCompra : ItemDocumento
    {
        private Double prcCusto;
        MItemCompra conexao = new MItemCompra();

        public Double getPrcCusto(){ return this.prcCusto; }
        public void setPrcCusto(Double prcCusto){ this.prcCusto = prcCusto; }

        public override int NovoId() => conexao.GetNovoId();
        public void CadItemCompra(ItemCompra ItemCompra)
        {
            conexao.InserirItemCompra(ItemCompra);
            Produto produto = new Produto();
            produto.EntradaEstoqueProduto(ItemCompra.getQtdItens(), ItemCompra.getIdProduto());
        }
        public List<ItemCompra> ListaItemCompra(int idCompra) => conexao.ListaItemCompra(idCompra);
    }
}