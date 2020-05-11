using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MFornecedor : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbfornecedor";
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
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            this.Conect();

            sql = "INSERT INTO tbfornecedor(razaosocial, cnpj, telefone, endereco)";
            sql = sql + "VALUES(@razaosocial, @cnpj, @telefone, @endereco); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("razaosocial", fornecedor.getRazaosocial());
            cmd.Parameters.AddWithValue("cnpj", fornecedor.getCnpj());
            cmd.Parameters.AddWithValue("endereco", fornecedor.getEndereco());
            cmd.Parameters.AddWithValue("telefone", fornecedor.getTelefone());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
            //Console.WriteLine("row inserted");
        }
        public List<Fornecedor> ListaFornecedor()
        {
            List<Fornecedor> Lista = new List<Fornecedor>();
            this.Conect();
            sql = "SELECT id, razaosocial, cnpj, telefone, endereco FROM tbfornecedor order by id";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.setId(rdr.GetInt32(0));
                fornecedor.setRazaosocial(rdr.GetString(1));
                fornecedor.setCnpj(rdr.GetString(2));
                fornecedor.setTelefone(rdr.GetString(3));
                fornecedor.setEndereco(rdr.GetString(4));

                Lista.Add(fornecedor);
            }
            this.Desconect();
            return Lista;
        }
        public Fornecedor getFornecedor(int idFornecedor)
        {
            Conect();
            Fornecedor fornecedor = new Fornecedor();
            sql = "SELECT id, razaosocial, cnpj, telefone, endereco FROM tbfornecedor where id = @id";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idFornecedor);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));                
                fornecedor.setId(rdr.GetInt32(0));
                fornecedor.setRazaosocial(rdr.GetString(1));
                fornecedor.setCnpj(rdr.GetString(2));
                fornecedor.setTelefone(rdr.GetString(3));
                fornecedor.setEndereco(rdr.GetString(4));
            }
            this.Desconect();
            return fornecedor;
        }
        public String getNomeFornecedor(int idFornecedor)
        {
            Conect();
            Fornecedor fornecedor = new Fornecedor();
            sql = "SELECT id, razaosocial, cnpj, telefone, endereco FROM tbfornecedor where id = @id";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idFornecedor);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                fornecedor.setId(rdr.GetInt32(0));
                fornecedor.setRazaosocial(rdr.GetString(1));
                fornecedor.setCnpj(rdr.GetString(2));
                fornecedor.setTelefone(rdr.GetString(3));
                fornecedor.setEndereco(rdr.GetString(4));
            }
            this.Desconect();
            return fornecedor.getRazaosocial();
        }
    }
}
