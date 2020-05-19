using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LojaRoupas.Classes;
using LojaRoupas.Model;

namespace LojaRoupas.Controller
{
    class COperador
    {
        MOperador conexao = new MOperador();
        MVenda venda = new MVenda();

        public int NovoId() => conexao.GetNovoId();
        public void InserirOperador(Operador operador) => conexao.InserirOperador(operador);
        public void EditarOperador(Operador Operador) => conexao.EditarOperador(Operador);
        public void ExcluirOperador(int idOperador)
        {
            if (venda.QtdVendaOperador(idOperador) == 0)
            {
                try
                {
                    conexao.ExcluirOperador(idOperador);
                    MessageBox.Show("Operador Excluído com Sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operador possui vendas e não pode ser excluído", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public List<Operador> ListarOperador() => conexao.ListarOperador();
        public Operador GetOperador(int id) => conexao.GetOperador(id);
        public String GetNomeOperador(int id) => conexao.GetNomeOperador(id);
        public int GetIDOperador(string NomeOperador) => conexao.GetIDOperador(NomeOperador);
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