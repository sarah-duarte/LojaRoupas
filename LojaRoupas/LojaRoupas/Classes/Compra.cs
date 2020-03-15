using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Compra : Documento
    {
        private int idFornecedor;
        private ItemCompra[] itensCompra;
        public int getIdFornecedor()
        {
            return this.idFornecedor;
        }
        public void setIdFornecedor(int idFornecedor)
        {
            this.idFornecedor = idFornecedor;
        }
        public ItemCompra[] getItensCompra()
        {
            return this.itensCompra;
        }
        public void setItensCompra(ItemCompra[] itensCompra)
        {
            this.itensCompra = itensCompra;
        }
    }
}
