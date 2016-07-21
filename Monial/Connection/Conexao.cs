using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monial.Connection
{
    class Conexao
    {
        private static string connString = "Data Source=LUKAS-PC\\SERVO;Database=monitoramento;User ID=sa;Password=spotGF2008";
        private static SqlConnection conn = null;

        public static SqlConnection abrirConexao()
        {
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (SqlException sqle)
            {
                conn = null;
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}

//Código para abri a conexão
//Conexao.abrirConexao();
//            SqlConnection conn = Conexao.abrirConexao();

//            if (conn == null)
//            {
//                MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
//            }
//            else
//            {
//                MessageBox.Show("A conexão foi obtida com sucesso.");
//            }
//            Conexao.fecharConexao();




