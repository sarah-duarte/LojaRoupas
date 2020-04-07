using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class ItemCompra : ItemDocumento
    {
        private Double prcCusto;
        public Double getPrcCusto(){ return this.prcCusto; }
        public void setPrcCusto(Double prcCusto){ this.prcCusto = prcCusto; }
    }
}