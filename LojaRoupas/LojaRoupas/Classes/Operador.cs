using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaRoupas.Model;

namespace LojaRoupas.Classes
{
    class Operador : Pessoa
    {
        private string turno;
        public void setTurno(string turno){ this.turno = turno; }
        public string getTurno(){ return this.turno; }

        public int NovoId()
        {
            MOperador conexao = new MOperador();
            return conexao.GetNovoId();
        }
        public void cadOperador(Operador operador)
        {
            MOperador conexao = new MOperador();
            conexao.InserirOperador(operador);
        }
        public List<Operador> ListaOperador()
        {
            MOperador conexao = new MOperador();
            return conexao.ListaOperador();
        }
    }
}