using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaRoupas.Model;
using System.Drawing;
using System.Windows.Forms;
using LojaRoupas.Classes;
using System.IO;
using System.ComponentModel;
using System.Data;


namespace LojaRoupas.Classes
{
    class Operador : Pessoa
    {
        private string turno;

        public void setTurno(string turno){ this.turno = turno; }
        public string getTurno(){ return this.turno; }
    }
}