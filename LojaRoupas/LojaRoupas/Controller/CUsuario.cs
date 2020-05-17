using LojaRoupas.Classes;
using LojaRoupas.Model;
using System;
using System.Collections.Generic;

namespace LojaRoupas.Controller
{
    class CUsuario
    {
        MUsuario conexao = new MUsuario();
        public int NovoId() => conexao.GetNovoId();
        public void InserirUsuario(Usuario Usuario) => conexao.InserirUsuario(Usuario);
        public void EditarUsuario(Usuario Usuario) => conexao.EditarUsuario(Usuario);
        public void ExcluirUsuario(int idUsuario) => conexao.ExcluirUsuario(idUsuario);
        public List<Usuario> ListarUsuario() => conexao.ListarUsuario();
        public Usuario GetUsuario(int id) => conexao.getUsuario(id);
        public Usuario GetUsuario(string Login) => conexao.getUsuario(Login);
        public String GetNomeUsuario(int id) => conexao.getNomeUsuario(id);
        public String GetSenhaUsuario(string Login) => conexao.getSenhaUsuario(Login);
        public void SalvarUsuario(Usuario Usuario)
        {
            if (GetUsuario(Usuario.getId()).getId() == 0)
            {
                InserirUsuario(Usuario);
            }
            else
            {
                EditarUsuario(Usuario);
            }
        }
        public void TelaUsuario(int idUsuario)
        {
            frmUsuarios telaUsuario = new frmUsuarios();
            telaUsuario.Usuario = GetUsuario(idUsuario);
            telaUsuario.ShowDialog();
        }
        public void TelaListaUsuario()
        {
            frmListaUsuario telaListaUsuario = new frmListaUsuario();
            telaListaUsuario.ShowDialog();
        }
    }
}