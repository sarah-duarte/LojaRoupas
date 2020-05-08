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
        private Double vlrTotal;
        private Double desconto;
        private int qtdItens;

        public void setID(int id) { this.id = id; }
        public void setData(String data) { this.data = data; }
        public void setVlrTotal(Double vlrTotal) { this.vlrTotal = vlrTotal; }
        public void setDesconto(Double desconto) { this.desconto = desconto; }
        public void setQtdItens(int qtdItens) { this.qtdItens = qtdItens; }

        public int getId() { return this.id; }
        public String getData() { return this.data; }
        public Double getVlrTotal() { return this.vlrTotal; }
        public Double getDesconto() { return this.desconto; }
        public int getQtdItens() { return this.qtdItens; }

        public virtual int NovoId() { return 0; }
    }
}