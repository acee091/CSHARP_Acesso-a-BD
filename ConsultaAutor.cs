using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acesso_a_BD
{
    class ConsultaAutor
    {
        public void fazerConsulta(string consulta)
        { 
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            try{
                conn.Open();
                SqlCommand comando = new SqlCommand(consulta, conn);

                SqlDataReader drDados = null;

                drDados = comando.ExecuteReader();

                if(drDados.HasRows)
                {
                    while (drDados.Read())
                    {
                        Variaveis.CaixatxtNomeAutor = (string)drDados["NomeAutor"];

                        Variaveis.CaixatxtSobrenomeAutor = (string)drDados["SobrenomeAutor"];
                    }
                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                }
                drDados.Close();
                conn.Close();
              }                
            catch(SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
        }
    }
}
