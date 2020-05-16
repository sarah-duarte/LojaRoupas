using System;
using System.Collections.Generic;

namespace LojaRoupas.Classes
{
    class Cliente : Pessoa
    {
        private int comprasRealizadas;

        public void setComprasRealizadas(int comprasRealizadas){ this.comprasRealizadas = comprasRealizadas; }
        public int getComprasRealizadas(){ return this.comprasRealizadas; }
    }
}