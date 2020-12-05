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
        public Cliente GetCliente(int id) => conexao.GetCliente(id);
        public String GetNomeCliente(int id) => conexao.GetNomeCliente(id);
        public int GetIdCliente(string NomeCliente) => conexao.GetIdCliente(NomeCliente);
        public String GetMoedaCliente(int idCliente) => conexao.GetMoedaCliente(idCliente);
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
        public void AjustarSaldo(int id, Double valor)
        {
            if (conexao.GetSaldoCliente(id) <= valor)
            {
                try
                {
                    conexao.AjustarSaldo(id, valor);
                }
                catch (IOException erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cliente não possui saldo em Carteira suficiente!", "Saldo em Carteira", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void TransferirSaldo(int idClienteOrigem, int idClienteDestino, Double valor, string moeda)
        {
            if (conexao.GetMoedaCliente(idClienteOrigem) == moeda)
            {
                if (conexao.GetSaldoCliente(idClienteOrigem) <= valor)
                { 
                    try
                    {
                        conexao.TransferirSaldo(idClienteOrigem, idClienteDestino, valor);
                        MessageBox.Show("Transferencia realizada com Sucesso!", "Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException erro)
                    {
                        MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não possui saldo em Carteira suficiente!", "Saldo em Carteira", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chave de cliente invalida!", "Chave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}