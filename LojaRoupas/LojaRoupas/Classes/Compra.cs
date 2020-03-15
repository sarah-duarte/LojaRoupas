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
    }
}
