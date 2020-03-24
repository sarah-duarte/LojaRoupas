using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Pessoa
    {
        private int id;
        private string nome;
        private int cpf;
        private string email;
        private int telefone;
        private int nascimento;
        private string endereco;

        public void setId(int id){ this.id = id; }
        public void setNome(string nome){ this.nome = nome; }
        public void setCpf(int cpf){ this.cpf = cpf; }
        public void setEmail(string email){ this.email = email; }
        public void setTelefone(int telefone){ this.telefone = telefone; }
        public void setNascimento(int nascimento){ this.nascimento = nascimento; }
        public void setEndereco(string endereco){ this.endereco = endereco; }

        public int getId(){ return this.id; }
        public string getNome(){ return this.nome; }
        public int getCpf(){ return this.cpf; }
        public string getEmail(){ return this.email; }
        public int getTelefone(){ return this.telefone; }
        public int getNascimento(){ return this.nascimento; }
        public string getEndereco(){ return this.endereco; }
    }
}