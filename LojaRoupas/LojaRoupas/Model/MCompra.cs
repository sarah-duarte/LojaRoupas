using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;
using LojaRoupas.Controller;

namespace LojaRoupas.Model
{
    class MCompra : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbcompra";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ultimoid = rdr.GetInt32(0);
            }
            this.Desconect();
            return ultimoid + 1;
        }
        public void InserirCompra(Compra c)
        {
            this.Conect();

            sql = "INSERT INTO tbcompra(data, vlrtotal, desconto, qtditens, idfornecedor)";
            sql = sql + "VALUES(@data, @vlrtotal, @desconto, @qtditens, @idfornecedor); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("data", c.getData());
            cmd.Parameters.AddWithValue("vlrtotal", c.getVlrTotal());
            cmd.Parameters.AddWithValue("desconto", c.getDesconto());
            cmd.Parameters.AddWithValue("qtditens", c.getQtdItens());
            cmd.Parameters.AddWithValue("idfornecedor", c.getIdFornecedor());
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.Desconect();
        }
        public List<Compra> ListaCompra()
        {
            List<Compra> Lista = new List<Compra>();
            this.Conect();
            sql = "SELECT id, data, vlrtotal, desconto, qtditens, idfornecedor FROM tbcompra order by id;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Compra c = new Compra();
                CItemCompra i = new CItemCompra();
                List<ItemCompra> itensCompra = new List<ItemCompra>();
                c.setID(rdr.GetInt32(0));
                c.setData(rdr.GetString(1));
                c.setVlrTotal(rdr.GetDouble(2));
                c.setDesconto(rdr.GetDouble(3));
                c.setQtdItens(rdr.GetInt32(4));
                c.setIdFornecedor(rdr.GetInt32(5));
                itensCompra = i.ListarItemCompra(c.getId()); 
                c.setItensCompra(itensCompra);
                Lista.Add(c);
            }
            this.Desconect();
            return Lista;
        }
    }
}