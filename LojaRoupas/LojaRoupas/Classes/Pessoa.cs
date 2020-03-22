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

        //SETS
        public void Setid(int id){ this.id = id; }
        public void SetNome(string nome){ this.nome = nome; }
        public void Setcpf(int cpf){ this.cpf = cpf; }
        public void SetEmail(string email){ this.email = email; }
        public void SetTelefone(int telefone){ this.telefone = telefone; }
        public void Setnascimento(int nascimento){ this.nascimento = nascimento; }
        public void SetEndereco(string endereco){ this.endereco = endereco; }
        //GETS
        public int getid(){ return this.id; }
        public string getNome(){ return this.nome; }
        public int getcpf(){ return this.cpf; }
        public string getemail(){ return this.email; }
        public int getTelefone(){ return this.telefone; }
        public int getnascimento(){ return this.nascimento; }
        public string getEndereco(){ return this.endereco; }
    }
}
