using MySql.Data.MySqlClient;
using System.Data;

namespace AppWeb.Config
{
    public class Conexao : IConexao
    {
        public Conexao()
        {           
        }
        public IDbConnection OpenConnection()
        {
            using(MySqlConnection conexao = new MySqlConnection("Server=rapidex-server.mysql.database.azure.com; Port=3306; Database=rapidex; Uid=lsantiago@rapidex-server; Pwd=C1853b13; SslMode=Preferred;"))
            {
                conexao.Open();
                return conexao;
            }
        }
    }
}




//"Server=localhost; Port=3306; Database=Rapidex; Uid=root; Pwd='853211';"