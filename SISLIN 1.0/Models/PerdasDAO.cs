using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISLIN_1._0.Interfaces;
using SISLIN_1._0.Database;

namespace SISLIN_1._0.Models
{
    class PerdasDAO : IDAO<Perdas>
    {
        private static Conexao conn;

        public PerdasDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Perdas t)
        {
            throw new NotImplementedException();
        }

        public Perdas GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Perdas t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO despesas id_despesa, nome_despesa, valor_despesa" +
                    "VALUES (@id,@nome,@valor)";

                query.Parameters.AddWithValue("@id", t.ID);
                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@valor", t.Valor);
                
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

        public List<Perdas> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Perdas t)
        {
            throw new NotImplementedException();
        }
    }
}
