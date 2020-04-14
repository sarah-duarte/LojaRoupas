using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MOperador : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tboperador";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            return ultimoid + 1;
        }
        public void InserirOperador(Operador operador)
        {
            this.Conect();

            sql = "INSERT INTO tboperador(nome, cpf, email, telefone, nascimento, endereco, turno)) ";
            sql = sql + "VALUES(@nome, @cpf, @email, @telefone, @nascimento, @endereco, @turno); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("nome", operador.getNome());
            cmd.Parameters.AddWithValue("cpf", operador.getCpf());
            cmd.Parameters.AddWithValue("email", operador.getEmail());
            cmd.Parameters.AddWithValue("telefone", operador.getTelefone());
            cmd.Parameters.AddWithValue("nascimento", operador.getNascimento());
            cmd.Parameters.AddWithValue("endereco", operador.getEndereco());
            cmd.Parameters.AddWithValue("turno", operador.getTurno());
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }

        public List<Operador> ListaOperador()
        {
            List<Operador> Lista = new List<Operador>();
            this.Conect();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, turno FROM tboperador;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                Operador o = new Operador();
                o.setId(rdr.GetInt32(0));
                o.setNome(rdr.GetString(1));
                o.setCpf(rdr.GetString(2));
                o.setEmail(rdr.GetString(3));
                o.setTelefone(rdr.GetString(4));
                o.setNascimento(rdr.GetString(5));
                o.setEndereco(rdr.GetString(6));
                o.setTurno(rdr.GetString(7));
                Lista.Add(o);
            }
            return Lista;
        }
    }
}
