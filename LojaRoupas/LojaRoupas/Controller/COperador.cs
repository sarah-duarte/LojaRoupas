using System;
using System.Collections.Generic;
using LojaRoupas.Classes;
using LojaRoupas.Model;

namespace LojaRoupas.Controller
{
    class COperador
    {
        MOperador conexao = new MOperador();

        public int NovoId() => conexao.GetNovoId();
        public void InserirOperador(Operador operador) => conexao.InserirOperador(operador);
        public void EditarOperador(Operador Operador) => conexao.EditarOperador(Operador);
        public void ExcluirOperador(int idOperador) => conexao.ExcluirOperador(idOperador);
        public List<Operador> ListarOperador() => conexao.ListarOperador();
        public Operador GetOperador(int id) => conexao.getOperador(id);
        public String GetNomeOperador(int id) => conexao.getNomeOperador(id);
        public void SalvarOperador(Operador Operador)
        {
            if (GetOperador(Operador.getId()).getId() == 0)
            {
                InserirOperador(Operador);
            }
            else
            {
                EditarOperador(Operador);
            }
        }
        public void TelaOperador(int idOperador)
        {
            frmOperador telaOperador = new frmOperador();
            telaOperador.Operador = GetOperador(idOperador);
            telaOperador.ShowDialog();
        }
        public void TelaListaOperador()
        {
            frmListaOperador telaListaOperador = new frmListaOperador();
            telaListaOperador.ShowDialog();
        }
    }
}
