using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Documento
    {
        private int id;
        private DateTime data;
        private float vlrTotal;
        private float desconto;
        private int qtdItens;

        public void setID(int id) { this.id = id; }
        public void setData(DateTime data) { this.data = data; }
        public void setVlrTotal(float vlrTotal) { this.vlrTotal = vlrTotal; }
        public void setDesconto(float desconto) { this.desconto = desconto; }
        public void setQtdItens(int qtdItens) { this.qtdItens = qtdItens; }

        public int getId() { return this.id; }
        public DateTime getData() { return this.data; }
        public float getVlrTotal() { return this.vlrTotal; }
        public float getDesconto() { return this.desconto; }
        public int getQtdItens() { return this.qtdItens; }
    }
}