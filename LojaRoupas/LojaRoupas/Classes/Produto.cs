using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Produto
    {
        /*- ID int        
        - CodigoBarras
        - descrição
        - cor
        - tamanho
        - precoCusto
        - precoVenda
        - qtdEstoque
        */

        private int    idProduto;
        private string descProduto;
        private string corProduto;
        private string tamProduto;
        private float  precProduto;
        private float  precProdutoVenda;
        private int    qtdProduto;



        public int getIdProduto()

        {
            return this.idProduto;
        }
        public void setIdProduto(int idProduto)
        {
            this.idProduto = idProduto;
        }

        public string getDescProduto()

        {
            return this.descProduto;
        }
        public void setDescProduto(string descProduto)
        {
            this.descProduto = descProduto;
        }

        public string getCorProduto()
        {
            return this.corProduto;
        }
        public void setCorProduto(string corProduto)
        {
            this.corProduto = corProduto;
        }

        public string getTamProduto()
        {
            return this.tamProduto;
        }
        public void setTamProduto(string tamProduto)
        {
            this.tamProduto = tamProduto;
        }

        public float getPrecProduto()
        {
            return this.precProduto;
        }
        public void setPrecProduto(float precProduto)
        {
            this.precProduto = precProduto;
        }

        public float getPrecProdutoVenda()
        {
            return this.precProdutoVenda;
        }
        public void setPrecProdutoVendao(float precProdutoVenda)
        {
            this.precProdutoVenda = precProdutoVenda;
        }

        public int getQtdProduto()

        {
            return this.qtdProduto;
        }
        public void setQtdProduto(int qtdProduto)
        {
            this.qtdProduto = qtdProduto;
        }
    }

}
    

