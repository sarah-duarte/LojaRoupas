using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupas.Classes
{
    class Operador : Pessoa
    {
        /*- Turno*/
        private string turno;

        //SET
        public void Setturno(string turno)
        {
            this.turno = turno;
        }

        //GET
        public string getturno()
        {
            return this.turno;
        }
    }
}
