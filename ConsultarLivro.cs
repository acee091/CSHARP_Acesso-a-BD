using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Biblioteca de acesso a banco de dados
using System.Windows.Forms;

namespace Acesso_a_BD
{
    class ConsultarLivro
    {
        public void fazerConsulta(string consulta) // criar metodo/função para consultar no BD
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            try//tentar realizar a operação
            {
                // Abrir a conexão com o banco de dados
                conn.Open();
                //Criar comando de consulta:
                SqlCommand comando = new SqlCommand(consulta, conn);

                //Criar o DataReader:
                SqlDataReader drDados = null;

                //Executar a consulta no banco de dados:
                drDados = comando.ExecuteReader();

                if (drDados.HasRows)//Verificar se há linhas retornadas
                {
                    while (drDados.Read())
                    {
                        //Obter os resultados das colunas 
                        Variaveis.CaixaTxtNomeLivro = (string)drDados["NomeLivro"];

                        //Preço do livro é decimal, convertemos e arredondamos 
                        Variaveis.CaixaTxtPrecoLivro = string.Format("{0:0.00}" drDados["PrecoLivro"]);

                        Variaveis.CaixaTxtDataPub = (DateTime)drDados["DataPub"];
                    }
                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }

        }
    }
}
