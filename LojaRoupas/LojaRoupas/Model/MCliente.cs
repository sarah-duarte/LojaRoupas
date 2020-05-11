using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MCliente : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbcliente";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            this.Desconect();
            return ultimoid + 1;            
        }
        public void InserirCliente(Cliente cliente)
        {
            this.Conect();

            sql = "INSERT INTO tbcliente(nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas) ";
            sql = sql + "VALUES(@nome, @cpf, @email, @telefone, @nascimento, @endereco, @comprasrealizadas); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("nome", cliente.getNome());
            cmd.Parameters.AddWithValue("cpf", cliente.getCpf());
            cmd.Parameters.AddWithValue("email", cliente.getEmail());
            cmd.Parameters.AddWithValue("telefone", cliente.getTelefone());
            cmd.Parameters.AddWithValue("nascimento", cliente.getNascimento());
            cmd.Parameters.AddWithValue("endereco", cliente.getEndereco());
            cmd.Parameters.AddWithValue("comprasrealizadas", cliente.getComprasRealizadas());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
            //Console.WriteLine("row inserted");
        }
        public List<Cliente> ListaCliente()
        {
            List<Cliente> Lista = new List<Cliente>();
            this.Conect();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas FROM tbcliente order by id;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                Cliente c = new Cliente();
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setComprasRealizadas(rdr.GetInt32(7));
                Lista.Add(c);
            }
            this.Desconect();
            return Lista;
        }
        public Cliente getCliente(int idCliente)
        {
            this.Conect();
            Cliente c = new Cliente();            
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas FROM tbcliente where id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCliente);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));                
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setComprasRealizadas(rdr.GetInt32(7));
            }
            this.Desconect();
            return c;
        }
        public String getNomeCliente(int idCliente)
        {
            this.Conect();
            Cliente c = new Cliente();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas FROM tbcliente where id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCliente);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setComprasRealizadas(rdr.GetInt32(7));
            }
            this.Desconect();
            return c.getNome();
        }
    }
}