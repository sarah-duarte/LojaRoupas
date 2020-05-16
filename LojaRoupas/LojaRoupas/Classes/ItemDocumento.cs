using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class ItemDocumento
    {
        private int id;
        private int idProduto;
        private int idDocumento;
        private int qtdItens;
        private Double totalPreco;

        public void setID(int id) { this.id = id; }
        public void setIdProduto(int idProduto) { this.idProduto = idProduto; }
        public void setIdDocumento(int idDocumento) { this.idDocumento = idDocumento; }
        public void setQtdItens(int qtdItens) { this.qtdItens = qtdItens; }
        public void setTotalPreco(Double totalPreco) { this.totalPreco = totalPreco; }

        public int getId() { return this.id; }
        public int getIdProduto() { return this.idProduto; }
        public int getIdDocumento() { return this.idDocumento; }
        public int getQtdItens() { return this.qtdItens; }
        public Double getTotalPreco() { return this.totalPreco; }
    }
}