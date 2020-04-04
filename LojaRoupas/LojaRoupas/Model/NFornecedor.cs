using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;


namespace LojaRoupas.Model
{
    class NFornecedor : Conexao
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
                Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            return ultimoid + 1;
        }
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            this.Conect();

            sql = "INSERT INTO public.tbfornecedor(razaosocial, cnpj, telefone, endereco)";
            sql = sql + "VALUES(@razaosocial, @cnpj, @telefone, @endereco); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cnpj", fornecedor.getCnpj());
            cmd.Parameters.AddWithValue("razao_social", fornecedor.getRazaosocial());
            cmd.Parameters.AddWithValue("endereco", fornecedor.getEndereco());
            cmd.Parameters.AddWithValue("telefone", fornecedor.getTelefone());
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }

        public List<Fornecedor> ListaProduto()
        {
            List<Fornecedor> Lista = new List<Fornecedor>();
            this.Conect();
            sql = "SELECT id, razaosocial, cnpj, telefone, endereco FROM public.tbfornecedor";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.setId(rdr.GetInt32(0));
                fornecedor.setCnpj(rdr.GetString(1));
                fornecedor.setRazaosocial(rdr.GetString(2));
                fornecedor.setEndereco(rdr.GetString(3));
                fornecedor.setTelefone(rdr.GetString(4));

                Lista.Add(fornecedor);
            }
            return Lista;
        }
    }
}
