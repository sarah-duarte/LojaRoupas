using System.Collections.Generic;

namespace LojaRoupas.Classes
{
    class Compra : Documento
    {
        private int idFornecedor;
        private List<ItemCompra> itensCompra;

        public int getIdFornecedor(){ return this.idFornecedor; }
        public List<ItemCompra> getItensCompra() { return this.itensCompra; }

        public void setIdFornecedor(int idFornecedor){ this.idFornecedor = idFornecedor; }
        public void setItensCompra(List<ItemCompra> itensCompra){ this.itensCompra = itensCompra; }
    }
}