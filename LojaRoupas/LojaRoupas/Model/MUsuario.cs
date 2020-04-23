using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MUsuario : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbusuario";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            return ultimoid + 1;
        }
        public void InserirUsuario(Usuario Usuario)
        {
            this.Conect();

            sql = "INSERT INTO tbusuario(nome, cpf, email, telefone, nascimento, endereco, login, senha) ";
            sql = sql + "VALUES(@nome, @cpf, @email, @telefone, @nascimento, @endereco, @login, @senha); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("nome", Usuario.getNome());
            cmd.Parameters.AddWithValue("cpf", Usuario.getCpf());
            cmd.Parameters.AddWithValue("email", Usuario.getEmail());
            cmd.Parameters.AddWithValue("telefone", Usuario.getTelefone());
            cmd.Parameters.AddWithValue("nascimento", Usuario.getNascimento());
            cmd.Parameters.AddWithValue("endereco", Usuario.getEndereco());
            cmd.Parameters.AddWithValue("login", Usuario.getLogin());
            cmd.Parameters.AddWithValue("senha", Usuario.getSenha());
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }
        public List<Usuario> ListaUsuario()
        {
            List<Usuario> Lista = new List<Usuario>();
            this.Conect();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, login, senha FROM tbusuario order by id;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                Usuario c = new Usuario();
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setLogin(rdr.GetString(7));
                c.setSenha(rdr.GetString(8));
                Lista.Add(c);
            }
            return Lista;
        }
        public Usuario getUsuario(int idUsuario)
        {
            this.Conect();
            Usuario c = new Usuario();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, login, senha FROM tbusuario where id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idUsuario);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setLogin(rdr.GetString(7));
                c.setSenha(rdr.GetString(8));
            }
            return c;
        }
        public Usuario getUsuario(string Login)
        {
            this.Conect();
            Usuario c = new Usuario();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, login, senha FROM tbusuario where login = @Login;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", Login);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setLogin(rdr.GetString(7));
                c.setSenha(rdr.GetString(8));
            }
            return c;
        }
        public String getNomeUsuario(int idUsuario)
        {
            this.Conect();
            Usuario c = new Usuario();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, login, senha FROM tbusuario where id = @id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idUsuario);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setLogin(rdr.GetString(7));
                c.setSenha(rdr.GetString(8));
            }
            return c.getNome();
        }
        public String getSenhaUsuario(string Login)
        {
            this.Conect();
            Usuario c = new Usuario();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, login, senha FROM tbusuario where login = @Login;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", Login);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                c.setId(rdr.GetInt32(0));
                c.setNome(rdr.GetString(1));
                c.setCpf(rdr.GetString(2));
                c.setEmail(rdr.GetString(3));
                c.setTelefone(rdr.GetString(4));
                c.setNascimento(rdr.GetString(5));
                c.setEndereco(rdr.GetString(6));
                c.setLogin(rdr.GetString(7));
                c.setSenha(rdr.GetString(8));
            }
            return c.getSenha();
        }
    }
}
