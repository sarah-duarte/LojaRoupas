using LojaRoupas.Classes;
using LojaRoupas.Model;
using System.Collections.Generic;

namespace LojaRoupas.Controller
{
    class CItemVenda
    {
        MItemVenda conexao = new MItemVenda();
        public int NovoId() => conexao.GetNovoId();
        public void InserirItemVenda(ItemVenda itemVenda)
        {
            conexao.InserirItemVenda(itemVenda);
            CProduto produto = new CProduto();
            produto.SaidaEstoqueProduto(itemVenda.getQtdItens(), itemVenda.getIdProduto());
        }
        public List<ItemVenda> ListarItemVenda(int idVenda) => conexao.ListarItemVenda(idVenda);
        public void TelaItemVenda(List<ItemVenda> lista)
        {
            frmListaItensVenda telaItensVenda = new frmListaItensVenda();
            telaItensVenda.Lista = lista;
            telaItensVenda.ShowDialog();
        }
    }
}
