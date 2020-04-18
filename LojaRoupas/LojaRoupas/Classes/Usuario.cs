using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Usuario : Pessoa
    {
        private String login;
        private String senha;

        public void setLogin(String login) { this.login = login; }
        public void setSenha(String senha) { this.senha = senha; }
        public String getLogin() { return this.login; }
        public String getSenha() { return this.senha; }
    }
}
