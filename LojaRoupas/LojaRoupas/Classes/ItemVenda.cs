using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class ItemVenda : ItemDocumento
    {
        private float prcVenda;
        public float getPrcVenda(){ return this.prcVenda; }
        public void setPrcVenda(float prcVenda){ this.prcVenda = prcVenda; }
    }
}
