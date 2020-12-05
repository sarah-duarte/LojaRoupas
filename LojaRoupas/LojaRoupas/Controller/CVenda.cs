using LojaRoupas.Classes;
using LojaRoupas.Model;
using System.Collections.Generic;

namespace LojaRoupas.Controller
{
    class CVenda
    {
        MVenda conexao = new MVenda();
        CItemVenda iv = new CItemVenda();
        CCliente cc = new CCliente();
        public int NovoId() => conexao.GetNovoId();
        public void InserirVenda(Venda venda)
        {
            conexao.InserirVenda(venda);
            cc.AjustarSaldo(venda.getIdCliente(), venda.getVlrTotal());
            foreach (ItemVenda i in venda.getItensVenda())
            {
                iv.InserirItemVenda(i);
            }
        }
        public List<Venda> ListarVenda() => conexao.ListarVenda();
        public int QtdVendaCliente(int idCliente)
        {
            return conexao.QtdVendaCliente(idCliente);
        }
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