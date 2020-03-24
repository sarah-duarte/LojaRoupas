using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Cliente : Pessoa
    {
        private int comprasRealizadas;
        public void setComprasRealizadas(int comprasRealizadas){ this.comprasRealizadas = comprasRealizadas; }
        public int getComprasRealizadas(){ return this.comprasRealizadas; }
    }
}