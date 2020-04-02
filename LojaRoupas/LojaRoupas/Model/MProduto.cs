using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MProduto : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbproduto";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            return ultimoid + 1;
        }
        public void InserirProduto(Produto produto)
        {
            this.Conect();

            sql = "INSERT INTO tbproduto(codigobarras, descricao, cor, tamanho, precocusto, precovenda, qtdestoque) ";
            sql = sql + "VALUES(@codigoBarras, @descricao, @cor, @tamanho, @precoCusto, @precoVenda, @qtdEstoque); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("codigoBarras", produto.getCodigoBarras());
            cmd.Parameters.AddWithValue("descricao", produto.getDescProduto());
            cmd.Parameters.AddWithValue("cor", produto.getCorProduto());
            cmd.Parameters.AddWithValue("tamanho", produto.getTamProduto());
            cmd.Parameters.AddWithValue("precoCusto", produto.getPrecoCusto());
            cmd.Parameters.AddWithValue("precoVenda", produto.getPrecoVenda());
            cmd.Parameters.AddWithValue("qtdEstoque", produto.getQtdEstProduto());
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }
        
        public List<Produto> ListaProduto()
        {
            List<Produto> Lista = new List<Produto>();
            this.Conect();
            sql = "SELECT  id, codigobarras, descricao, cor, tamanho, precocusto, precovenda, qtdestoque FROM tbproduto";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                Produto produto = new Produto();
                produto.setIdProduto(rdr.GetInt32(0));
                produto.setCodigoBarras(rdr.GetString(1));
                produto.setDescProduto(rdr.GetString(2));
                produto.setCorProduto(rdr.GetString(3));
                produto.setTamProduto(rdr.GetString(4));
                produto.setPrecoCusto(rdr.GetDouble(5));
                produto.setPrecoVenda(rdr.GetDouble(6));
                produto.setQtdEstProduto(rdr.GetInt32(7));
                Lista.Add(produto);
            }
            return Lista;
        }
    }
}
