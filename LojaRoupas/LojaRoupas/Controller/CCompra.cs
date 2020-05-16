using LojaRoupas.Classes;
using LojaRoupas.Model;
using System.Collections.Generic;

namespace LojaRoupas.Controller
{
    class CCompra
    {
        MCompra conexao = new MCompra();
        CItemCompra ic = new CItemCompra();
        public int NovoId() => conexao.GetNovoId();
        public void InserirCompra(Compra Compra)
        {
            conexao.InserirCompra(Compra);
            foreach (ItemCompra i in Compra.getItensCompra())
            {
                ic.InserirItemCompra(i);
            }
        }
        public List<Compra> ListarCompra() => conexao.ListaCompra();
        public void TelaCompra()
        {
            frmCompra telaCompra = new frmCompra();
            telaCompra.ShowDialog();
        }
        public void TelaListaCompra()
        {
            frmListaCompra telaListaCompra = new frmListaCompra();
            telaListaCompra.ShowDialog();
        }
    }
}
