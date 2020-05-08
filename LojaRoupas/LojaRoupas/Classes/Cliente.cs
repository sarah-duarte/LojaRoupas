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
        public List<Cliente> ListaCliente() => conexao.ListaCliente();
        public Cliente getCliente(int id) => conexao.getCliente(id);
        public String getNomeCliente(int id) => conexao.getNomeCliente(id);
    }
}