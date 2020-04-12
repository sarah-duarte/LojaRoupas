using System;
using System.Collections.Generic;
using LojaRoupas.Model;
using LojaRoupas.Classes;
using System.Windows.Forms;


namespace LojaRoupas.Classes
{
    class Cliente : Pessoa
    {
        private int comprasRealizadas;
        public void setComprasRealizadas(int comprasRealizadas){ this.comprasRealizadas = comprasRealizadas; }
        public int getComprasRealizadas(){ return this.comprasRealizadas; }

        public int NovoId()
        {
            MCliente conexao = new MCliente();
            return conexao.GetNovoId();
        }
        public void cadCliente(Cliente cliente)
        {
            MCliente conexao = new MCliente();
            conexao.InserirCliente(cliente);
        }
        public List<Cliente> ListaCliente()
        {
            MCliente conexao = new MCliente();
            return conexao.ListaCliente();
        }

    }
}