namespace LojaRoupas.Classes
{
    class Operador : Pessoa
    {
        private string turno;

        public void setTurno(string turno){ this.turno = turno; }
        public string getTurno(){ return this.turno; }
    }
}