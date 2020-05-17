using System;

namespace LojaRoupas.Classes
{
    class Usuario : Pessoa
    {
        private string login;
        private string senha;

        public void setLogin(String login) { this.login = login; }
        public void setSenha(String senha) { this.senha = senha; }
        public String getLogin() { return this.login; }
        public String getSenha() { return this.senha; }
    }
}
