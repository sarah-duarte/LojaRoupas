using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class ItemVenda : ItemDocumento
    {
        private Double prcVenda;
        public Double getPrcVenda(){ return this.prcVenda; }
        public void setPrcVenda(Double prcVenda){ this.prcVenda = prcVenda; }

        public int NovoId()
        {
            MItemVenda conexao = new MItemVenda();
            return conexao.GetNovoId();
        }
        public void cadVenda(ItemVenda itemVenda)
        {
            MItemVenda conexao = new MItemVenda();
            conexao.InserirItemVenda(itemVenda);
        }
        public List<ItemVenda> ListaItemVenda(int idVenda)
        {
            MItemVenda conexao = new MItemVenda();
            return conexao.ListaItemVenda(idVenda);
        }
    }
}