using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Fornecedor
    {
        /*- ID int
        - CNPJ
        - Razão Social
        - endereço
        - telefone*/
        private int id;
        private int cnpj;
        private string razaosocial;
        private string endereco;

        //SETS
        public void Setid(int id){ this.id = id; }
        public void Setcnpj(int cnpj){ this.cnpj = cnpj; }
        public void Setrazaosocial(string razaosocial){ this.razaosocial = razaosocial; }
        public void SetEndereco(string endereco){ this.endereco = endereco; }

        //GETS
        public int getid(){ return this.id; }
        public int getcnpj(){ return this.cnpj; }
        public string getrazaosocial(){ return this.razaosocial; }
        public string getEndereco(){ return this.endereco; }
    }
}
