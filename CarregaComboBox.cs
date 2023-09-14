using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acesso_a_BD
{
    class CarregaComboBox
    {
        public List<string> carregaComboBox(string SQL, string coluna) 
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            List<string> Item = new List<string>();
            try
            {
                conn.Open();
                SqlCommand consulta = new SqlCommand(SQL, conn);

                //Criar o DataReader
                SqlDataReader drDados =  null;
                
                //Executar a consulta
                drDados = consulta.ExecuteReader();

                if(drDados.HasRows) // Linhas retornadas
                {
                    while(drDados.Read())
                    {
                        Item.Add(drDados[coluna].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Registros não encontrados");
                }
                drDados.Close();
                conn.Close();
            }
            catch(SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            return Item;
        }
    }
}
