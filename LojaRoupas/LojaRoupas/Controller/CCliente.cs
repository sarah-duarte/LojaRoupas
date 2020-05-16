using System;
using System.Collections.Generic;
using LojaRoupas.Model;
using LojaRoupas.Classes;

namespace LojaRoupas.Controller
{
    class CCliente
    {
        MCliente conexao = new MCliente();

        public int NovoId() => conexao.GetNovoId();
        public void InserirCliente(Cliente cliente) => conexao.InserirCliente(cliente);
        public void EditarCliente(Cliente cliente) => conexao.EditarCliente(cliente);
        public void ExcluirCliente(int idCliente) => conexao.ExcluirCliente(idCliente);
        public List<Cliente> ListarCliente() => conexao.ListarCliente();
        public Cliente GetCliente(int id) => conexao.getCliente(id);
        public String GetNomeCliente(int id) => conexao.getNomeCliente(id);

        public void TelaCliente()
        {
            frmCliente telaCliente = new frmCliente();
            telaCliente.ShowDialog();
        }
        public void TelaListaCliente()
        {
            frmListaCliente telaListaCliente = new frmListaCliente();
            telaListaCliente.ShowDialog();
        }
    }
}
