using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Venda : Documento
    {
        private int idCliente;
        private ItemVenda[] itensVenda;
        public int getIdCliente()
        {
            return this.idCliente;
        }
        public void setIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }
    }
}
