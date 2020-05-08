using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class Compra : Documento
    {
        private int idFornecedor;
        private List<ItemCompra> itensCompra;
        MCompra conexao = new MCompra();

        public int getIdFornecedor(){ return this.idFornecedor; }
        public List<ItemCompra> getItensCompra() { return this.itensCompra; }

        public void setIdFornecedor(int idFornecedor){ this.idFornecedor = idFornecedor; }
        public void setItensCompra(List<ItemCompra> itensCompra){ this.itensCompra = itensCompra; }

        public override int NovoId() => conexao.GetNovoId();
        public void CadCompra(Compra Compra)
        {
            conexao.InserirCompra(Compra);
            foreach (ItemCompra i in itensCompra)
            {
                i.CadItemCompra(i);
            }
        }
        public List<Compra> ListaCompra() => conexao.ListaCompra();
    }
}