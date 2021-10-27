using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISLIN_1._0.Interfaces;
using SISLIN_1._0.Database;


namespace SISLIN_1._0.Models
{
    class Cadas_promoDAO : IDAO<Cadas_promo>
    {
        private static Conexao Conn; 
        public Cadas_promoDAO()
        {
            Conn = new Conexao();
        }
        public void Delete(Cadas_promo t)
        {
            throw new NotImplementedException();
        }

        public Cadas_promo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cadas_promo t)
        {
            try
            {
                var query = Conn.Query();
                query.CommandText = "INSERT INTO Cadas_promo (id_Cadas_promo _func, valor_promo_func, Local_promo_func,Nome_cliente_func, Celular_cliente_func )"
                    + "VALUES (@id_promo @valor_promo @local_promo @nome_cliente @celular_cliente)";
                query.Parameters.AddWithValue("@id_promo", t.ID_promo);
                query.Parameters.AddWithValue("@valor_promo", t.Valor_promo);
                query.Parameters.AddWithValue("@local_promo", t.Local_promo);
                query.Parameters.AddWithValue("@nome_cliente", t. Nome_cliente);
                query.Parameters.AddWithValue("@celular_cliente", t.Celular_cliente);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Promoção apliclada com sucesso!");


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Conn.Close();
            }
        }

        public List<Cadas_promo> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Cadas_promo t)
        {
            throw new NotImplementedException();
        }
    }
}
