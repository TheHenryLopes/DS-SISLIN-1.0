using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISLIN_1._0.Interfaces;
using SISLIN_1._0.Database;

namespace SISLIN_1._0.Models
{
    class ClienteDAO : IDAO<Cliente>
    {
        private Conexao conn;

        public ClienteDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Cliente t)
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cliente t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO cliente(nome_cliente,cpf_cliente,rg_cliente,cnpj_cliente,nome_fanclientetasia_cliente,email_cliente,telefone_cliente,telefone_fixo_cliente) " + 
                    "VALUES (@nome, @cpf, @rg, @cnpj,@nomefan,@email, @telefone,@telefonefx)";
                query.Parameters.AddWithValue("@nome",t.nome_cliente);
                query.Parameters.AddWithValue("@cpf",t.cpf_cliente);
                query.Parameters.AddWithValue("@rg", t.rg_cliente);
                query.Parameters.AddWithValue("@cnpj", t.cnpj_cliente);
                query.Parameters.AddWithValue("@nomefan", t.nome_fanclientetasia_cliente);
                query.Parameters.AddWithValue("@email", t.email_cliente);
                query.Parameters.AddWithValue("@telefone", t.telefone_cliente);
                query.Parameters.AddWithValue("@telefonefx", t.telefone_fixo_cliente);

                var result = query.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            } finally
            {
                conn.Close();
            }
        }

        public List<Cliente> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente t)
        {
            throw new NotImplementedException();
        }
    }
}
