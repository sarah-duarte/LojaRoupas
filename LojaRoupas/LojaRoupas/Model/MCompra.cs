using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

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
                Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
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

            Console.WriteLine("row inserted");
        }

        public List<Compra> ListaCompra()
        {
            List<Compra> Lista = new List<Compra>();
            this.Conect();
            sql = "SELECT id, data, vlrtotal, desconto, qtditens, idfornecedor FROM tbcompra;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                Compra c = new Compra();
                c.setID(rdr.GetInt32(0));
                c.setData(rdr.GetString(1));
                c.setVlrTotal(rdr.GetDouble(2));
                c.setDesconto(rdr.GetDouble(3));
                c.setQtdItens(rdr.GetInt32(4));
                c.setIdFornecedor(rdr.GetInt32(5));
                Lista.Add(c);
            }
            return Lista;
        }
    }
}