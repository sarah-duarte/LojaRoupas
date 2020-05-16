using LojaRoupas.Classes;
using LojaRoupas.Model;
using System.Collections.Generic;

namespace LojaRoupas.Controller
{
    class CItemCompra
    {
        MItemCompra conexao = new MItemCompra();
        public int NovoId() => conexao.GetNovoId();
        public void InserirItemCompra(ItemCompra ItemCompra)
        {
            conexao.InserirItemCompra(ItemCompra);
            CProduto produto = new CProduto();
            produto.EntradaEstoqueProduto(ItemCompra.getQtdItens(), ItemCompra.getIdProduto());
        }
        public List<ItemCompra> ListarItemCompra(int idCompra) => conexao.ListarItemCompra(idCompra);
        public void TelaItemCompra(List<ItemCompra> lista)
        {
            frmListaItensCompra telaItensCompra = new frmListaItensCompra();
            telaItensCompra.Lista = lista;
            telaItensCompra.ShowDialog();
        }
    }
}
