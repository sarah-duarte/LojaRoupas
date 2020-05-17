using System;
using System.Collections.Generic;
using LojaRoupas.Model;
using LojaRoupas.Classes;
using System.Windows.Forms;
using System.IO;

namespace LojaRoupas.Controller
{
    class CCliente
    {
        MCliente conexao = new MCliente();
        MVenda venda = new MVenda();

        public int NovoId() => conexao.GetNovoId();
        public void InserirCliente(Cliente cliente) => conexao.InserirCliente(cliente);
        public void EditarCliente(Cliente cliente) => conexao.EditarCliente(cliente);
        public void ExcluirCliente(int idCliente)
        {
            if (venda.QtdVendaCliente(idCliente) == 0)
            {
                try
                {
                    conexao.ExcluirCliente(idCliente);
                    MessageBox.Show("Cliente Excluído com Sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            else
            {
                MessageBox.Show("Cliente possui vendas e não pode ser excluído", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<Cliente> ListarCliente() => conexao.ListarCliente();
        public Cliente GetCliente(int id) => conexao.getCliente(id);
        public String GetNomeCliente(int id) => conexao.getNomeCliente(id);
        public void SalvarCliente(Cliente cliente)
        {
            if (GetCliente(cliente.getId()).getId() == 0)
            {
                InserirCliente(cliente);
            }
            else
            {
                EditarCliente(cliente);
            }
        }
        public void TelaCliente(int idCliente)
        {
            frmCliente telaCliente = new frmCliente();
            telaCliente.Cliente = GetCliente(idCliente);
            telaCliente.ShowDialog();
        }
        public void TelaListaCliente()
        {
            frmListaCliente telaListaCliente = new frmListaCliente();
            telaListaCliente.ShowDialog();
        }
    }
}
