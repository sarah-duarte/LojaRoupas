using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class Venda : Documento
    {
        private int idCliente;
        private int idOperador;
        private List<ItemVenda> itensVenda;
        
        public void setIdCliente(int idCliente){ this.idCliente = idCliente; }
        public void setIdOperador(int idOperador) { this.idOperador = idOperador; }
        public void setItensVenda(List<ItemVenda> itensVenda) { this.itensVenda = itensVenda; }

        public int getIdCliente() { return this.idCliente; }
        public int getIdOperador() { return this.idOperador; }
        public List<ItemVenda> getItensVenda(){ return this.itensVenda; }

        public int NovoId()
        {
            MVenda conexao = new MVenda();
            return conexao.GetNovoId();
        }
        public void cadVenda(Venda venda)
        {
            MVenda conexao = new MVenda();
            conexao.InserirVenda(venda);
            foreach (ItemVenda i in itensVenda)
            {
                i.cadItemVenda(i);
            }
        }
        public List<Venda> ListaVenda()
        {
            MVenda conexao = new MVenda();
            return conexao.ListaVenda();
        }
    }
}