using LojaRoupas.Classes;
using LojaRoupas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Controller
{
    class CVenda
    {
        MVenda conexao = new MVenda();
        CItemVenda iv = new CItemVenda();
        public int NovoId() => conexao.GetNovoId();
        public void InserirVenda(Venda venda)
        {
            conexao.InserirVenda(venda);
            foreach (ItemVenda i in venda.getItensVenda())
            {
                iv.InserirItemVenda(i);
            }
        }
        public List<Venda> ListarVenda() => conexao.ListarVenda();
        public void TelaVenda()
        {
            frmVenda telaVenda = new frmVenda();
            telaVenda.ShowDialog();
        }
        public void TelaListaVenda()
        {
            frmListaVenda telaListaVenda = new frmListaVenda();
            telaListaVenda.ShowDialog();
        }
    }
}
