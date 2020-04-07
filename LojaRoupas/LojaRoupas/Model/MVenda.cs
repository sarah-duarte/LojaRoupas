using System;
using System.Collections.Generic;
using Npgsql;
using LojaRoupas.Classes;

namespace LojaRoupas.Model
{
    class MVenda : Conexao
    {
        public override int GetNovoId()
        {
            int ultimoid = 0;
            this.Conect();
            sql = "SELECT (case when max(id) is null then 0 else max(id) end) as novoitem FROM tbvenda";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                ultimoid = rdr.GetInt32(0);
            }
            return ultimoid + 1;
        }
        public void InserirVenda(Venda v)
        {
            this.Conect();

            sql = "INSERT INTO tbvenda(data, vlrtotal, desconto, qtditens, idcliente, idoperador)";
            sql = sql + "VALUES(@data, @vlrtotal, @desconto, @qtditens, @idcliente, @idoperador); ";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("data", v.getData());
            cmd.Parameters.AddWithValue("vlrtotal", v.getVlrTotal());
            cmd.Parameters.AddWithValue("desconto", v.getDesconto());
            cmd.Parameters.AddWithValue("qtditens", v.getQtdItens());
            cmd.Parameters.AddWithValue("idcliente", v.getIdCliente());
            cmd.Parameters.AddWithValue("idoperador", v.getIdOperador());
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }

        public List<Venda> ListaVenda()
        {
            List<Venda> Lista = new List<Venda>();
            this.Conect();
            sql = "SELECT id, data, vlrtotal, desconto, qtditens, idcliente, idoperador FROM tbvenda;";
            cmd = new NpgsqlCommand(sql, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0}", rdr.GetInt32(0));
                Venda v = new Venda();
                v.setID(rdr.GetInt32(0));
                v.setData(rdr.GetString(1));
                v.setVlrTotal(rdr.GetDouble(2));
                v.setDesconto(rdr.GetDouble(3));
                v.setQtdItens(rdr.GetInt32(4));
                v.setIdCliente(rdr.GetInt32(5));
                v.setIdOperador(rdr.GetInt32(6));
                Lista.Add(v);
            }
            return Lista;
        }
    }
}
