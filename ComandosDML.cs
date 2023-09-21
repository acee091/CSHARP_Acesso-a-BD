using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Acesso_a_BD
{
    class ComandosDML
    {
        //Metódo para inserir, atualizar ou excluir registros:
        public void iud(string sql) //void -> não retorna nada 
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            //Executar a operação no banco de dados:
            cmd.ExecuteNonQuery(); //Executar todas as operações menos a CONSULTA

            conn.Close();
        }
    }
}
