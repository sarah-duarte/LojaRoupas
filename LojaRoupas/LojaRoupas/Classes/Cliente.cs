using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class Cliente : Pessoa
    {
        private int comprasRealizadas;
        MCliente conexao = new MCliente();

        public void setComprasRealizadas(int comprasRealizadas){ this.comprasRealizadas = comprasRealizadas; }
        public int getComprasRealizadas(){ return this.comprasRealizadas; }

        public override int NovoId() => conexao.GetNovoId();
        public void cadCliente(Cliente cliente) => conexao.InserirCliente(cliente);
        public void EditarCliente(Cliente cliente) => conexao.EditarCliente(cliente);
        public void ExcluirCliente(int idCliente) => conexao.ExcluirCliente(idCliente);
        public List<Cliente> ListaCliente() => conexao.ListarCliente();
        public Cliente getCliente(int id) => conexao.getCliente(id);
        public String getNomeCliente(int id) => conexao.getNomeCliente(id);
    }
}