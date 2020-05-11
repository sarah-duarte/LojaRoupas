using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MItemCompra : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbitemcompra";
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
        public void InserirItemCompra(ItemCompra i)
        {
            this.Conect();

            sql = "INSERT INTO tbitemcompra(idproduto, qtditens, totalpreco, prccompra, idcompra)";
            sql = sql + "VALUES(@idproduto, @qtditens, @totalpreco, @prccompra, @idcompra); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("idproduto", i.getIdProduto());
            cmd.Parameters.AddWithValue("qtditens", i.getQtdItens());
            cmd.Parameters.AddWithValue("totalpreco", i.getTotalPreco());
            cmd.Parameters.AddWithValue("prccompra", i.getPrcCusto());
            cmd.Parameters.AddWithValue("idcompra", i.getIdDocumento());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
            //Console.WriteLine("row inserted");
        }
        public List<ItemCompra> ListaItemCompra(int idCompra)
        {
            List<ItemCompra> Lista = new List<ItemCompra>();
            this.Conect();
            sql = "SELECT id, idproduto, qtditens, totalpreco, prccompra, idcompra FROM tbitemcompra where idcompra = @idcompra order by id;";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("idcompra", idCompra);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Console.WriteLine("{0}", rdr.GetInt32(0));
                ItemCompra i = new ItemCompra();
                i.setID(rdr.GetInt32(0));
                i.setIdProduto(rdr.GetInt32(1));
                i.setQtdItens(rdr.GetInt32(2));
                i.setTotalPreco(rdr.GetDouble(3));
                i.setPrcCusto(rdr.GetDouble(4));
                i.setIdDocumento(rdr.GetInt32(5));
                Lista.Add(i);
            }
            this.Desconect();
            return Lista;
        }
    }
}