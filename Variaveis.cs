using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acesso_a_BD
{
    public static class Variaveis //Public pra ser acessivel fora da programação 
    {
        //String de conexão ao banco de dados
        public static string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=db_MeusLivros;User ID=sa;Password=123456";
        public static string CaixaTxtNomeLivro { get; set; } // get: ler/obter o dado -- set: escrever

        public static string CaixaTxtPrecoLivro { get; set; }

        public static DateTime CaixaTxtDataPub { get; set; }

        public static string CaixatxtNomeAutor { get; set; }

        public static string CaixatxtSobrenomeAutor { get; set; }

        public static string CaixatxtNomeEditora { get; set; }

    }
}
