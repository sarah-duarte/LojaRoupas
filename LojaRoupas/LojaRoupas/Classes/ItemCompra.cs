using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class ItemCompra : ItemDocumento
    {
        private float prcCusto;
        public float getPrcCusto(){ return this.prcCusto; }
        public void setPrcCusto(float prcCusto){ this.prcCusto = prcCusto; }
    }
}
