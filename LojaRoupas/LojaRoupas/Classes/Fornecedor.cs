using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Fornecedor
    {
        private int id;
        private int cnpj;
        private string razaosocial;
        private string endereco;
        private int telefone;

        public void setId(int id){ this.id = id; }
        public void setCnpj(int cnpj){ this.cnpj = cnpj; }
        public void setRazaosocial(string razaosocial){ this.razaosocial = razaosocial; }
        public void setEndereco(string endereco){ this.endereco = endereco; }
        public void setTelefone(int telefone) { this.telefone = telefone; }
        
        public int getId(){ return this.id; }
        public int getCnpj(){ return this.cnpj; }
        public string getRazaosocial(){ return this.razaosocial; }
        public string getEndereco(){ return this.endereco; }
        public int getTelefone() { return this.telefone; }
    }
}