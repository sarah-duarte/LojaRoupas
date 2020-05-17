namespace LojaRoupas.Classes
{
    class Fornecedor 
    {
        private int id;
        private string cnpj;
        private string razaosocial;
        private string endereco;
        private string telefone;

        public void setId(int id){ this.id = id; }
        public void setCnpj(string cnpj){ this.cnpj = cnpj; }
        public void setRazaosocial(string razaosocial){ this.razaosocial = razaosocial; }
        public void setEndereco(string endereco){ this.endereco = endereco; }
        public void setTelefone(string telefone) { this.telefone = telefone; }
        
        public int getId(){ return this.id; }
        public string getCnpj(){ return this.cnpj; }
        public string getRazaosocial(){ return this.razaosocial; }
        public string getEndereco(){ return this.endereco; }
        public string getTelefone() { return this.telefone; }
    }
}