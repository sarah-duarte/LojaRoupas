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
        private String data;
        private float vlrTotal;
        private float desconto;
        private int qtdItens;

        public void setID(int id) { this.id = id; }
        public void setData(String data) { this.data = data; }
        public void setVlrTotal(float vlrTotal) { this.vlrTotal = vlrTotal; }
        public void setDesconto(float desconto) { this.desconto = desconto; }
        public void setQtdItens(int qtdItens) { this.qtdItens = qtdItens; }

        public int getId() { return this.id; }
        public String getData() { return this.data; }
        public float getVlrTotal() { return this.vlrTotal; }
        public float getDesconto() { return this.desconto; }
        public int getQtdItens() { return this.qtdItens; }
    }
}