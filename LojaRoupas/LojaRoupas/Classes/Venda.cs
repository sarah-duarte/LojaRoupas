using System.Collections.Generic;

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
    }
}