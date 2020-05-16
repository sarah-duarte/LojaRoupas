using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class ItemCompra : ItemDocumento
    {
        private Double prcCusto;

        public Double getPrcCusto(){ return this.prcCusto; }
        public void setPrcCusto(Double prcCusto){ this.prcCusto = prcCusto; }
    }
}