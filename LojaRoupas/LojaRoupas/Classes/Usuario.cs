using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class Usuario : Pessoa
    {
        private string login;
        private string senha;
        MUsuario conexao = new MUsuario();

        public void setLogin(String login) { this.login = login; }
        public void setSenha(String senha) { this.senha = senha; }
        public String getLogin() { return this.login; }
        public String getSenha() { return this.senha; }

        public override int NovoId() => conexao.GetNovoId();
        public void cadUsuario(Usuario Usuario) => conexao.InserirUsuario(Usuario);
        public void EditarUsuario(Usuario Usuario) => conexao.EditarUsuario(Usuario);
        public void ExcluirUsuario(int idUsuario) => conexao.ExcluirUsuario(idUsuario);
        public List<Usuario> ListaUsuario() => conexao.ListarUsuario();
        public Usuario getUsuario(int id) => conexao.getUsuario(id);
        public Usuario getUsuario(string Login) => conexao.getUsuario(Login);
        public String getNomeUsuario(int id) => conexao.getNomeUsuario(id);
        public String getSenhaUsuario(string Login) => conexao.getSenhaUsuario(Login);
    }
}
