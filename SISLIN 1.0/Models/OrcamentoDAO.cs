using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISLIN_1._0.Interfaces;
using SISLIN_1._0.Database;
using MySql.Data.MySqlClient;

namespace SISLIN_1._0.Models
{
    class OrcamentoDAO : IDAO<Orcamento>
    {

        private static Conexao conn;

        public OrcamentoDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Orcamento t)
        {
            throw new NotImplementedException();
        }

        public Orcamento GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Orcamento t)
        {
            try
            { 
                var query = conn.Query();
                query.CommandText = "INSERT INTO Orcamento (id_orcamento, data_orcamento, " +
                    "descrisao_orcamento,desconto_orcamento, unidade_orcamento, quantdd_orcamento, " +
                    "valor_orcamento)" +
                    "VALUES (@id,@data,@descrisao,@desconto,@unidd,@quantdd,@valor)";

                query.Parameters.AddWithValue("@id", t.ID);
                query.Parameters.AddWithValue("@data", t.Data);
                query.Parameters.AddWithValue("@descrisao", t.Descrisao);
                query.Parameters.AddWithValue("@desconto", t.Desconto);
                query.Parameters.AddWithValue("@unidd", t.Unidade);
                query.Parameters.AddWithValue("@quantdd", t.Quantdd);
                query.Parameters.AddWithValue("@valor", t.Valor);

                var result = query.ExecuteNonQuery();
               
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Orcamento> List()
        {
            try
            {
                List<Orcamento> list = new List<Orcamento>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Orcamento";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Orcamento()
                    {
                        Data = reader.GetDateTime("data_orcamento"),
                        Descrisao = reader.GetString("descrisao_orcamento"),
                        Desconto = reader.GetInt32("desconto_orcamento"),
                        Unidade = reader.GetInt32("unidade_orcamento"),
                        Quantdd = reader.GetInt32("quantdd_orcamento"),
                        Valor = reader.GetDouble("valor_orcamento"),
                    });
                }

                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update(Orcamento t)
        {
            throw new NotImplementedException();
        }
    }
}
