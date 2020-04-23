using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class Usuario : Pessoa
    {
        private String login;
        private String senha;
        MUsuario conexao = new MUsuario();

        public void setLogin(String login) { this.login = login; }
        public void setSenha(String senha) { this.senha = senha; }
        public String getLogin() { return this.login; }
        public String getSenha() { return this.senha; }

        public int NovoId() => conexao.GetNovoId();
        public void cadUsuario(Usuario Usuario) => conexao.InserirUsuario(Usuario);
        public List<Usuario> ListaUsuario() => conexao.ListaUsuario();
        public Usuario getUsuario(int id) => conexao.getUsuario(id);
        public Usuario getUsuario(string Login) => conexao.getUsuario(Login);
        public String getNomeUsuario(int id) => conexao.getNomeUsuario(id);
        public String getSenhaUsuario(string Login) => conexao.getSenhaUsuario(Login);
    }
}
