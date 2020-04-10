﻿using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MItemVenda : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbitemvenda";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            return ultimoid + 1;
        }
        public void InserirItemVenda(ItemVenda i)
        {
            this.Conect();

            sql = "INSERT INTO tbitemvenda(idproduto, qtditens, totalpreco, prcvenda, idvenda)";
            sql = sql + "VALUES(@idproduto, @qtditens, @totalpreco, @prcvenda, @idvenda); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("idproduto", i.getIdProduto());
            cmd.Parameters.AddWithValue("qtditens", i.getQtdItens());
            cmd.Parameters.AddWithValue("totalpreco", i.getTotalPreco());
            cmd.Parameters.AddWithValue("prcvenda", i.getPrcVenda());
            cmd.Parameters.AddWithValue("idvenda", i.getIdDocumento());
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }

        public List<ItemVenda> ListaItemVenda(int idVenda)
        {
            List<ItemVenda> Lista = new List<ItemVenda>();
            this.Conect();
            sql = "SELECT id, idproduto, qtditens, totalpreco, prcvenda, idvenda FROM tbitemvenda where idvenda = @idvenda;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("idvenda", idVenda);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                ItemVenda i = new ItemVenda();
                i.setID(rdr.GetInt32(0));
                i.setIdProduto(rdr.GetInt32(1));
                i.setQtdItens(rdr.GetInt32(2));
                i.setTotalPreco(rdr.GetDouble(3));
                i.setPrcVenda(rdr.GetDouble(4));
                i.setIdDocumento(rdr.GetInt32(5));
                Lista.Add(i);
            }
            return Lista;
        }
    }
}