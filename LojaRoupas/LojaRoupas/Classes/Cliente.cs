using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Cliente : Pessoa
    {
        private int comprasrealizadas;

        //SET
        public void Setcomprasrealizadas(int comprasrealizadas)
        {
            this.comprasrealizadas = comprasrealizadas;
        }

        //GET
        public int getcomprasrealizadas()
        {
            return this.comprasrealizadas;
        }
    }
}
