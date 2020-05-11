using System;
using Npgsql;

namespace LojaRoupas.Model
{
    class Conexao
    {
        public NpgsqlConnection con;
        public NpgsqlCommand cmd;
        public NpgsqlDataReader rdr;
        public String cs;
        public String sql;
        public void Conect()
        {
            cs = "Host=localhost;Username=admin;Password=admin;Database=dbLojaRoupas";
            con = new NpgsqlConnection(cs);
            con.Open();
            //Console.WriteLine("Conectado");
        }
        public void Desconect()
        {
            con.Close();
        }
        public virtual int GetNovoId() { return 0; }
    }
}