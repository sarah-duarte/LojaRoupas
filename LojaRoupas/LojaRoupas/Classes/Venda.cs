using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class Venda : Documento
    {
        private int idCliente;
        private int idOperador;
        private List<ItemVenda> itensVenda;
        MVenda conexao = new MVenda();

        public void setIdCliente(int idCliente){ this.idCliente = idCliente; }
        public void setIdOperador(int idOperador) { this.idOperador = idOperador; }
        public void setItensVenda(List<ItemVenda> itensVenda) { this.itensVenda = itensVenda; }

        public int getIdCliente() { return this.idCliente; }
        public int getIdOperador() { return this.idOperador; }
        public List<ItemVenda> getItensVenda(){ return this.itensVenda; }

        public override int NovoId() => conexao.GetNovoId();
        public void CadVenda(Venda venda)
        {
            conexao.InserirVenda(venda);
            foreach (ItemVenda i in itensVenda)
            {
                i.CadItemVenda(i);
            }
        }
        public List<Venda> ListaVenda() => conexao.ListaVenda();
    }
}