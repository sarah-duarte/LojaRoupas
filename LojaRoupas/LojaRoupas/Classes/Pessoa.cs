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
        private string cpf;
        private string email;
        private string telefone;
        private string nascimento;
        private string endereco;

        public void setId(int id){ this.id = id; }
        public void setNome(string nome){ this.nome = nome; }
        public void setCpf(string cpf){ this.cpf = cpf; }
        public void setEmail(string email){ this.email = email; }
        public void setTelefone(string telefone){ this.telefone = telefone; }
        public void setNascimento(string nascimento){ this.nascimento = nascimento; }
        public void setEndereco(string endereco){ this.endereco = endereco; }

        public int getId(){ return this.id; }
        public string getNome(){ return this.nome; }
        public string getCpf(){ return this.cpf; }
        public string getEmail(){ return this.email; }
        public string getTelefone(){ return this.telefone; }
        public string getNascimento(){ return this.nascimento; }
        public string getEndereco(){ return this.endereco; }
    }
}