using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    public class Produto

    {

        private string nome_produto;

        private string fornecedor_produto;

        private string fabricante_produto;

        private string obs_produto;

        private double preco_produto;

        private double quantidade_produto;



        public string Nome_produto

        {

            get { return nome_produto; }

            set { nome_produto = value; }



        }



        public string Fornecedor_produto

        {

            get { return fornecedor_produto; }

            set { fornecedor_produto = value; }



        }

        public string Fabricante_produto

        {
            get { return fabricante_produto; }

            set { fabricante_produto = value; }
        }

        public string Obs_produto

        {

            get { return obs_produto; }

            set { obs_produto = value; }

        }

        public double Preco_produto

        {

            get { return preco_produto; }

            set { preco_produto = value; }
        }

        public double Quantidade_produto

        {

            get { return quantidade_produto; }

            set { quantidade_produto = value; }



        }

    }

}