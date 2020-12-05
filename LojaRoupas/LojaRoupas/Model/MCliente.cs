﻿using System;
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
                ultimoid = rdr.GetInt32(0);
            }
            this.Desconect();
            return ultimoid + 1;            
        }
        public void InserirCliente(Cliente cliente)
        {
            this.Conect();

            sql = "INSERT INTO tbcliente(nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas, carteira, conta, moeda) ";
            sql += "VALUES(@nome, @cpf, @email, @telefone, @nascimento, @endereco, @comprasrealizadas, @carteira, @conta, (MD5(concat(@nomeM, @cpfM, (select (case t.moeda when null then '0' else t.moeda end) from tbcliente t where t.id in (select max(id) from tbcliente)))))); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("nome", cliente.getNome());
            cmd.Parameters.AddWithValue("cpf", cliente.getCpf());
            cmd.Parameters.AddWithValue("email", cliente.getEmail());
            cmd.Parameters.AddWithValue("telefone", cliente.getTelefone());
            cmd.Parameters.AddWithValue("nascimento", cliente.getNascimento());
            cmd.Parameters.AddWithValue("endereco", cliente.getEndereco());
            cmd.Parameters.AddWithValue("comprasrealizadas", cliente.getComprasRealizadas());
            cmd.Parameters.AddWithValue("carteira", cliente.getCarteira());
            cmd.Parameters.AddWithValue("conta", cliente.getConta());
            cmd.Parameters.AddWithValue("nomeM", cliente.getNome());
            cmd.Parameters.AddWithValue("cpfM", cliente.getCpf());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
        public void EditarCliente(Cliente cliente)
        {
            this.Conect();

            sql = "UPDATE tbcliente SET nome=@nome, cpf=@cpf, email=@email, telefone=@telefone, nascimento=@nascimento, " +
                " endereco=@endereco, comprasrealizadas=@comprasrealizadas, carteira=@carteira, conta=@conta WHERE id=@id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", cliente.getId());
            cmd.Parameters.AddWithValue("nome", cliente.getNome());
            cmd.Parameters.AddWithValue("cpf", cliente.getCpf());
            cmd.Parameters.AddWithValue("email", cliente.getEmail());
            cmd.Parameters.AddWithValue("telefone", cliente.getTelefone());
            cmd.Parameters.AddWithValue("nascimento", cliente.getNascimento());
            cmd.Parameters.AddWithValue("endereco", cliente.getEndereco());
            cmd.Parameters.AddWithValue("comprasrealizadas", cliente.getComprasRealizadas());
            cmd.Parameters.AddWithValue("carteira", cliente.getCarteira());
            cmd.Parameters.AddWithValue("conta", cliente.getConta());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
        public void ExcluirCliente(int idCliente)
        {
            this.Conect();

            sql = "DELETE FROM tbcliente WHERE id=@id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCliente);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
        public List<Cliente> ListarCliente()
        {
            List<Cliente> Lista = new List<Cliente>();
            this.Conect();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas FROM tbcliente order by id;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
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
        public Cliente GetCliente(int idCliente)
        {
            this.Conect();
            Cliente c = new Cliente();            
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas, carteira, conta FROM tbcliente where id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCliente);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {                
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setComprasRealizadas(rdr.GetInt32(7));
                c.setCarteira(rdr.GetDouble(8));
                c.setConta(rdr.GetString(9));
            }
            this.Desconect();
            return c;
        }
        public String GetNomeCliente(int idCliente)
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
        public int GetIdCliente(string NomeCliente)
        {
            this.Conect();
            Cliente c = new Cliente();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas FROM tbcliente where nome = @nome;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("nome", NomeCliente);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
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
            return c.getId();
        }
        public String GetMoedaCliente(int idCliente)
        {
            this.Conect();
            Cliente c = new Cliente();
            sql = "SELECT moeda FROM tbcliente where id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCliente);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                c.setMoeda(rdr.GetString(0));
            }
            this.Desconect();
            return c.getMoeda();
        }
        public Double GetSaldoCliente(int idCliente)
        {
            this.Conect();
            Cliente c = new Cliente();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, comprasrealizadas, carteira FROM tbcliente where id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCliente);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setComprasRealizadas(rdr.GetInt32(7));
                c.setCarteira(rdr.GetDouble(8));
            }
            this.Desconect();
            return c.getCarteira();
        }
        public void AjustarSaldo(int idCliente, Double valor)
        {
            this.Conect();

            sql = "UPDATE tbcliente SET carteira=carteira-@carteira WHERE id=@id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCliente);
            cmd.Parameters.AddWithValue("carteira", valor);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
        public void TransferirSaldo(int idClienteOrigem, int idClienteDestino, Double valor)
        {
            this.Conect();

            sql = "UPDATE tbcliente SET carteira=carteira-@carteira WHERE id=@id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idClienteOrigem);
            cmd.Parameters.AddWithValue("carteira", valor);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();

            this.Conect();

            sql = "UPDATE tbcliente SET carteira=carteira+@carteira WHERE id=@id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idClienteDestino);
            cmd.Parameters.AddWithValue("carteira", valor);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
    }
}