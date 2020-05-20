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
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            this.Desconect();
            return ultimoid + 1;
        }
        public void InserirUsuario(Usuario usuario)
        {
            this.Conect();

            sql = "INSERT INTO tbusuario(nome, cpf, email, telefone, nascimento, endereco, login, senha) ";
            sql = sql + "VALUES(@nome, @cpf, @email, @telefone, @nascimento, @endereco, @login, @senha); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("nome", usuario.getNome());
            cmd.Parameters.AddWithValue("cpf", usuario.getCpf());
            cmd.Parameters.AddWithValue("email", usuario.getEmail());
            cmd.Parameters.AddWithValue("telefone", usuario.getTelefone());
            cmd.Parameters.AddWithValue("nascimento", usuario.getNascimento());
            cmd.Parameters.AddWithValue("endereco", usuario.getEndereco());
            cmd.Parameters.AddWithValue("login", usuario.getLogin());
            cmd.Parameters.AddWithValue("senha", usuario.getSenha());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
            //Console.WriteLine("row inserted");
        }
        public void EditarUsuario(Usuario Usuario)
        {
            this.Conect();

            sql = "UPDATE tbusuario SET nome=@nome, cpf=@cpf, email=@email, telefone=@telefone, nascimento=@nascimento, " +
                " endereco=@endereco, login=@login, senha=@senha WHERE id=@id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", Usuario.getId());
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
            this.Desconect();
        }
        public void ExcluirUsuario(int idUsuario)
        {
            this.Conect();

            sql = "DELETE FROM tbusuario WHERE id=@id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idUsuario);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
        public List<Usuario> ListarUsuario()
        {
            List<Usuario> Lista = new List<Usuario>();
            this.Conect();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, login, senha FROM tbusuario order by id;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
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
            this.Desconect();
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
            this.Desconect();
            return c;
        }
        public Usuario getUsuario(string Login)
        {
            this.Conect();
            Usuario c = new Usuario();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, login, senha FROM tbusuario where login = @Login;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("login", Login);
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
                c.setLogin(rdr.GetString(7));
                c.setSenha(rdr.GetString(8));
            }
            this.Desconect();
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
            this.Desconect();
            return c.getNome();
        }
        public String getSenhaUsuario(string Login)
        {
            this.Conect();
            Usuario c = new Usuario();
            sql = "SELECT id, nome, cpf, email, telefone, nascimento, endereco, login, senha FROM tbusuario where login = @Login;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("login", Login);
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
                c.setLogin(rdr.GetString(7));
                c.setSenha(rdr.GetString(8));
            }
            this.Desconect();
            return c.getSenha();
        }
    }
}