using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISLIN_1._0.Interfaces;
using SISLIN_1._0.Database;

namespace SISLIN_1._0.Models 
{
    class orcamentoDAO : IDAO<Orcamento>
    {

        private static Conexao conn;

        public orcamentoDAO()
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
                query.CommandText = "INSERT INTO despesas id_orcamento, data_orcamento, valor_orcamento, via_orcamento" +
                    "VALUES (@id,@data,@valor, @via)";

                query.Parameters.AddWithValue("@id", t.ID);
                query.Parameters.AddWithValue("@nome", t.Data.ToString("yyyy-mm-dd"));
                query.Parameters.AddWithValue("@valor", t.Valor);
                query.Parameters.AddWithValue("@via", t.Via);

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
            throw new NotImplementedException();
        }

        public void Update(Orcamento t)
        {
            throw new NotImplementedException();
        }
    }
}
