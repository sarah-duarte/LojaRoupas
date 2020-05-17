using System;

namespace LojaRoupas.Classes
{
    class ItemVenda : ItemDocumento
    {
        private Double prcVenda;

        public Double GetPrcVenda(){ return this.prcVenda; }
        public void SetPrcVenda(Double prcVenda){ this.prcVenda = prcVenda; }
    }
}