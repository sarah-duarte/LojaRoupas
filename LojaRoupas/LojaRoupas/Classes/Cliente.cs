using System;

namespace LojaRoupas.Classes
{
    class Cliente : Pessoa
    {
        private int comprasRealizadas;
        private Double carteira;
        private string conta;
        private string moeda;

        public void setComprasRealizadas(int comprasRealizadas){ this.comprasRealizadas = comprasRealizadas; }
        public void setCarteira(Double carteira) { this.carteira = carteira; }
        public void setConta(string conta) { this.conta = conta; }
        public void setMoeda(string moeda) { this.moeda = moeda; }

        public int getComprasRealizadas(){ return this.comprasRealizadas; }
        public Double getCarteira() { return this.carteira; }
        public string getConta() { return this.conta; }
        public string getMoeda() { return this.moeda; }
    }
}