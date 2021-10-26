using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SISLIN_1._0.Database
{
    class Conexao
    {
        private static string host = "localhost";
        private static string port = "3306";
        private static string user = "root";
        private static string password = "12345";
        private static string dbname = "bd_SISLIN";
        private static MySqlConnection connection;
        private static MySqlCommand command;

        public Conexao()
        {
            try
            {
                connection = new MySqlConnection($"server={host};user={user};database={dbname};port={port};password={password}");
            } catch(Exception)
            {
                throw;
            }
        }
        
        public MySqlCommand Query()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                return command;
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        public void Close()
        {
            connection.Close();
        }
    }
}