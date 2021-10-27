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
    class EntrDinheiroDAO : IDAO<EntrDinheiro>
    {
        private static Conexao conc;

        public EntrDinheiroDAO()
        {
            conc = new Conexao();
        }

        public void Delete(EntrDinheiro t)
        {
            throw new NotImplementedException();
        }

        public EntrDinheiro GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(EntrDinheiro t)
        {
            try 
            {
                var query = conc.Query();
                query.CommandText = "INSERT INTO Venda (id_venda, data_venda, valor_venda, formaPagamento_venda)"
                    + "VALUES (null, @data, @valor @formPaga)";

                query.Parameters.AddWithValue("@data", t.Id_Dinheiro);
                query.Parameters.AddWithValue("@valor", t.Valor_Dinheiro);
                query.Parameters.AddWithValue("@formPaga", t.formapaga_Dinheiro);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Venda cadastrada com sucesso!");

            } catch (Exception e)
            {
                throw e;
            } finally
            {
                conc.Close();
            }
        }

        public List<EntrDinheiro> List()
        {
            try
            {
                List<EntrDinheiro> list = new List<EntrDinheiro>();

                var query = conc.Query();
                query.CommandText = "SELECT * FROM Venda";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new EntrDinheiro()
                    {
                        Data = reader.GetDateTime("data_venda"),
                        Valor_Dinheiro = reader.GetDouble("valor_venda"),
                        formapaga_Dinheiro = reader.GetString("formaPagamento_venda")                     
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
                conc.Close();
            }
        }

        public void Update(EntrDinheiro t)
        {
            throw new NotImplementedException();
        }
    }
}
